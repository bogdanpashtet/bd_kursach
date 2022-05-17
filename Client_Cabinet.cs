using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace RZ
{
    public partial class Client_Cabinet : Form
    {
        SqlConnection sql_connection;
        int id;
        public string data;

        // конструктор формы передает при ее инициализации логин пользователя
        public Client_Cabinet(string data)
        {
            InitializeComponent();
            this.data = data;
            login_label.Text = data;
        }
        
        // при запуске формы
        private void Enter_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-S3IVENA\SQLEXPRESS;Initial Catalog=RZ_db;Integrated Security=True";
            sql_connection = new SqlConnection(connectionString);

            // запоминаем id из предыдущей формы
            sql_connection.Open();
            var command = new SqlCommand("SELECT id FROM Client WHERE LOGIN = @LOGIN", sql_connection);
            command.Parameters.AddWithValue("@LOGIN", login_label.Text);
            id = (Int32)command.ExecuteScalar();
            command.ExecuteNonQuery();
            sql_connection.Close();

            UpdateCart();
            string str = "SELECT * FROM prod_for_client";
            ProductsShow(str);
        }
        
        // вывод покупок покупателя
        public void UpdateCart() {
            
            // очищаем таблицу
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            
            sql_connection.Open();
            var command = new SqlCommand("SELECT * FROM t_ction where \"ID клиента\" = @id;", sql_connection); //запрос на выполнение функции
            command.Parameters.AddWithValue("@id", id);
            SqlDataReader sqlReader = null; //объявление ридера
            sqlReader = command.ExecuteReader(); //открытие ридера
            List<string[]> data = new List<string[]>(); //Объявляем список для записи данных
            for (int i = 0; i < 8; i++)
            { //Задаем названия столбцам
                dataGridView1.Columns.Add(i.ToString(), sqlReader.GetName(i));
            }
            while (sqlReader.Read()) // пока есть данные
            {
                data.Add(new string[8]); //Добавляем строку в список
                data[data.Count - 1][0] = sqlReader[0].ToString(); //Считываем данные
                data[data.Count - 1][1] = sqlReader[1].ToString();
                data[data.Count - 1][2] = sqlReader[2].ToString();
                data[data.Count - 1][3] = sqlReader[3].ToString(); //Считываем данные
                data[data.Count - 1][4] = sqlReader[4].ToString();
                data[data.Count - 1][5] = sqlReader[5].ToString();
                data[data.Count - 1][6] = sqlReader[6].ToString();
                data[data.Count - 1][7] = sqlReader[7].ToString();
            }
            foreach (string[] s in data) //Для каждого набора данных добавляем строку
                dataGridView1.Rows.Add(s);
            sqlReader.Close();//Закрываем ридер
            command.ExecuteNonQuery();
            sql_connection.Close();//Закрываем подключение
        }

        // показать список товаров для клиента
        public void ProductsShow(string str) {

            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            sql_connection.Open(); //Открыть подключение к БД
            var command = new SqlCommand(str, sql_connection); //запрос на выполнение функции
            SqlDataReader sqlReader = null; //объявление ридера
            sqlReader = command.ExecuteReader(); //открытие ридера
            List<string[]> data = new List<string[]>(); //Объявляем список для записи данных
            for (int i = 0; i < 7; i++)
            { //Задаем названия столбцам
                dataGridView2.Columns.Add(i.ToString(), sqlReader.GetName(i));
            }
            while (sqlReader.Read()) // пока есть данные
            {
                data.Add(new string[7]); //Добавляем строку в список
                data[data.Count - 1][0] = sqlReader[0].ToString(); //Считываем данные
                data[data.Count - 1][1] = sqlReader[1].ToString();
                data[data.Count - 1][2] = sqlReader[2].ToString();
                data[data.Count - 1][3] = sqlReader[3].ToString(); //Считываем данные
                data[data.Count - 1][4] = sqlReader[4].ToString();
                data[data.Count - 1][5] = sqlReader[5].ToString();
                data[data.Count - 1][6] = sqlReader[6].ToString();
            }
            foreach (string[] s in data) //Для каждого набора данных добавляем строку
                dataGridView2.Rows.Add(s);
            sqlReader.Close();//Закрываем ридер
            command.ExecuteNonQuery();
            sql_connection.Close();//Закрываем подключение

        }

        // кнопка отправления жалоб
        private void complaint_button_Click(object sender, EventArgs e)
        {

            sql_connection.Open();
            var command = new SqlCommand("SELECT COUNT(id) FROM Seller WHERE id = @SL_ID", sql_connection);
            command.Parameters.AddWithValue("@SL_ID", rate_seller_id_textBox.Text);
            int fl0 = (Int32)command.ExecuteScalar();
            command.ExecuteNonQuery();
            sql_connection.Close();

            if (fl0 == 0)
                MessageBox.Show("Такого продавца не существует");
            else
            {
                string id_pattern = @"[\d]";

                if (!Regex.IsMatch(complaint_id_textBox.Text, id_pattern))
                    MessageBox.Show("Введите корректный id.");
                else if (complaint_textBox.TextLength == 0)
                    MessageBox.Show("Введите текст жалобы.");
                else
                {
                    sql_connection.Open();
                    command = new SqlCommand("NEW_COMPLAINT", sql_connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID", complaint_id_textBox.Text);
                    command.Parameters.AddWithValue("@TEXT", complaint_textBox.Text);
                    command.ExecuteNonQuery();
                    sql_connection.Close();

                    complaint_textBox.Text = "";
                    complaint_id_textBox.Text = "";
                    MessageBox.Show("Жалоба успешно отправлена.");
                }
            }
        }

        // оценить продавца
        private void rate_seller_button_Click(object sender, EventArgs e)
        {

            sql_connection.Open();
            var command = new SqlCommand("SELECT COUNT(id) FROM Seller WHERE id = @SL_ID", sql_connection);
            command.Parameters.AddWithValue("@SL_ID", rate_seller_id_textBox.Text);
            int fl0 = (Int32)command.ExecuteScalar();
            command.ExecuteNonQuery();
            sql_connection.Close();

            if (fl0 == 0)
                MessageBox.Show("Такого продавца не существует");
            else
            {
                sql_connection.Open();
                command = new SqlCommand("SELECT COUNT(id) FROM Rating WHERE (CLIENT_ID  = @CL_ID AND SELLER_ID  = @SL_ID)", sql_connection);
                command.Parameters.AddWithValue("@CL_ID", id);
                command.Parameters.AddWithValue("@SL_ID", rate_seller_id_textBox.Text);
                int fl = (Int32)command.ExecuteScalar();
                command.ExecuteNonQuery();
                sql_connection.Close();

                string id_pattern = @"[\d]";

                if (rate_textBox.Text == "")
                {
                    MessageBox.Show("Введите оценку");
                }
                else if (!Regex.IsMatch(rate_seller_id_textBox.Text, id_pattern))
                    MessageBox.Show("Введите корректный id.");
                else if (Convert.ToInt32(rate_textBox.Text) > 5 || Convert.ToInt32(rate_textBox.Text) < 1)
                {
                    MessageBox.Show("Неверное значение оценки. Введите значение от 1 до 5");
                }
                else if (fl == 0)
                {
                    sql_connection.Open();
                    command = new SqlCommand("NEW_RATING", sql_connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@RATE", rate_textBox.Text);
                    command.Parameters.AddWithValue("@CL_ID", id);
                    command.Parameters.AddWithValue("@SL_ID", rate_seller_id_textBox.Text);
                    command.ExecuteNonQuery();
                    sql_connection.Close();

                    rate_seller_id_textBox.Text = "";
                    rate_textBox.Text = "";
                    MessageBox.Show("Оценка поставлена.");

                    UpdateCart();
                }
                else
                {
                    sql_connection.Open();
                    command = new SqlCommand("ALTER_RATING", sql_connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@RATE", rate_textBox.Text);
                    command.Parameters.AddWithValue("@CL_ID", id);
                    command.Parameters.AddWithValue("@SL_ID", rate_seller_id_textBox.Text);
                    command.ExecuteNonQuery();
                    sql_connection.Close();

                    rate_seller_id_textBox.Text = "";
                    rate_textBox.Text = "";
                    MessageBox.Show("Оценка обновлена.");

                    UpdateCart();
                }
            }
        }

        // кнопка просмотра списка товаров
        private void product_view_button_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex) {
                case 0:
                    string str = "SELECT * FROM prod_for_client";
                    ProductsShow(str);
                    break;
                case 1:
                    str = "SELECT * FROM prod_for_client ORDER BY \"id продавца\"";
                    ProductsShow(str);
                    break;
                case 2:
                    str = "SELECT * FROM prod_for_client ORDER BY \"Категория\"";
                    ProductsShow(str);
                    break;
                case 3:
                    str = "SELECT * FROM prod_for_client ORDER BY \"Популярность\"";
                    ProductsShow(str);
                    break;
                default:
                    str = "SELECT * FROM prod_for_client";
                    ProductsShow(str);
                    break;

            }

        }

        // покупка
        private void buy_button_Click(object sender, EventArgs e)
        {

            string id_pattern = @"[\d]";

            if (!Regex.IsMatch(buy_product_textBox.Text, id_pattern))
                MessageBox.Show("Введите корректный id.");
            else {
                sql_connection.Open();
                var command = new SqlCommand("NEW_TRANSACTION", sql_connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CL_ID", id);
                command.Parameters.AddWithValue("@PR_ID", buy_product_textBox.Text);
                command.ExecuteNonQuery();
                sql_connection.Close();
            }

            buy_product_textBox.Text = "";

            string str = "SELECT * FROM prod_for_client";
            ProductsShow(str);
            UpdateCart();
        }

        // на главную
        private void on_main_page_button_Click(object sender, EventArgs e)
        {
            Form startForm = new StartForm(); //Открытие стартовой формы 
            startForm.Show();
            this.Hide();
        }
    }
}

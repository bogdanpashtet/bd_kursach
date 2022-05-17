using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace RZ
{
    public partial class Seller_Cabinet : Form
    {
        string data;
        int id;
        SqlConnection sql_connection;

        // конструктор формы передает при ее инициализации логин пользователя
        public Seller_Cabinet(string data)
        {
            InitializeComponent();
            this.data = data;
            login_label.Text = data;
        }
        
        // функция, вызывающиеся при загрузке формы
        private void Seller_Cabinet_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-S3IVENA\SQLEXPRESS;Initial Catalog=RZ_db;Integrated Security=True";
            sql_connection = new SqlConnection(connectionString);


            sql_connection.Open();
            var command = new SqlCommand("SELECT id FROM Seller WHERE LOGIN = @LOGIN", sql_connection); 
            command.Parameters.AddWithValue("@LOGIN", login_label.Text);
            id = (Int32)command.ExecuteScalar();
            command.ExecuteNonQuery();
            sql_connection.Close();


            sql_connection.Open();
            command = new SqlCommand("SELECT rating FROM Seller WHERE id = @ID", sql_connection); // выручка для продавца
            command.Parameters.AddWithValue("@ID", id);
            rating_label.Text = Convert.ToString(command.ExecuteScalar());        // заполняем label4 полученной информацией
            command.ExecuteNonQuery();
            sql_connection.Close();

            CountIncome();
            CountOfProd();

            FillingProductTable();

            // заполняем таблицу транзакций для продавца

            sql_connection.Open(); //Открыть подключение к БД
            command = new SqlCommand("SELECT * FROM FIND_SELLER_TRANSACTION (@id);", sql_connection); //запрос на выполнение функции
            command.Parameters.AddWithValue("id", id);
            SqlDataReader sqlReader = null; //объявление ридера
            sqlReader = command.ExecuteReader(); //открытие ридера
            List<string[]> data = new List<string[]>(); //Объявляем список для записи данных
            for (int i = 0; i < 6; i++)
            { //Задаем названия столбцам
                dataGridView2.Columns.Add(i.ToString(), sqlReader.GetName(i));
            }
            while (sqlReader.Read()) // пока есть данные
            {
                data.Add(new string[6]); //Добавляем строку в список
                data[data.Count - 1][0] = sqlReader[0].ToString(); //Считываем данные
                data[data.Count - 1][1] = sqlReader[1].ToString();
                data[data.Count - 1][2] = sqlReader[2].ToString();
                data[data.Count - 1][3] = sqlReader[3].ToString(); //Считываем данные
                data[data.Count - 1][4] = sqlReader[4].ToString();
                data[data.Count - 1][5] = sqlReader[5].ToString();
            }
            foreach (string[] s in data) //Для каждого набора данных добавляем строку
                dataGridView2.Rows.Add(s);
            sqlReader.Close();//Закрываем ридер
            command.ExecuteNonQuery();
            sql_connection.Close();//Закрываем подключение


            // жалобы на продавца
            sql_connection.Open(); //Открыть подключение к БД
            command = new SqlCommand("SELECT * FROM FIND_SELLER_COMPLAINT (@id);", sql_connection); //запрос на выполнение функции
            command.Parameters.AddWithValue("id", id);
            sqlReader = null; //объявление ридера
            sqlReader = command.ExecuteReader(); //открытие ридера
            data = new List<string[]>(); //Объявляем список для записи данных
            for (int i = 0; i < 1; i++)
            { //Задаем названия столбцам
                dataGridView3.Columns.Add(i.ToString(), sqlReader.GetName(i));
            }
            while (sqlReader.Read()) // пока есть данные
            {
                data.Add(new string[1]); //Добавляем строку в список
                data[data.Count - 1][0] = sqlReader[0].ToString(); //Считываем данные
            }
            foreach (string[] s in data) //Для каждого набора данных добавляем строку
                dataGridView3.Rows.Add(s);
            sqlReader.Close();//Закрываем ридер
            command.ExecuteNonQuery();
            sql_connection.Close();//Закрываем подключение

        }
        
        // добавленине товара в таблицу
        public void FillingProductTable() {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            sql_connection.Open(); 
            var command = new SqlCommand("SELECT * FROM FIND_SELLER_PRODUCTS(@id)", sql_connection); //запрос на выполнение функции
            command.Parameters.AddWithValue("id", id);
            SqlDataReader sqlReader = null; //объявление ридера
            sqlReader = command.ExecuteReader(); //открытие ридера
            List<string[]> data = new List<string[]>(); //Объявляем список для записи данных
            for (int i = 0; i < 5; i++)
            { //Задаем названия столбцам
                dataGridView1.Columns.Add(i.ToString(), sqlReader.GetName(i));
            }
            while (sqlReader.Read()) // пока есть данные
            {
                data.Add(new string[5]); //Добавляем строку в список
                data[data.Count - 1][0] = sqlReader[0].ToString(); //Считываем данные
                data[data.Count - 1][1] = sqlReader[1].ToString();
                data[data.Count - 1][2] = sqlReader[2].ToString();
                data[data.Count - 1][3] = sqlReader[3].ToString();
                data[data.Count - 1][4] = sqlReader[4].ToString();
            }
            foreach (string[] s in data) //Для каждого набора данных добавляем строку
                dataGridView1.Rows.Add(s);
            sqlReader.Close();//Закрываем ридер
            command.ExecuteNonQuery();
            sql_connection.Close();//Закрываем подключение
        }

        // подсчет доходов продавца
        public void CountIncome() {
            income_label.Text = "";
            sql_connection.Open();
            var command = new SqlCommand("SELECT dbo.summary_cost_of_contracts(@ID) FROM Seller", sql_connection); // выручка для продавца
            command.Parameters.AddWithValue("@ID", id);
            income_label.Text = Convert.ToString(command.ExecuteScalar());        // заполняем label4 полученной информацией
            command.ExecuteNonQuery();
            sql_connection.Close();
        }

        // подсчет количества товаров продавца
        public void CountOfProd() {
            count_of_product_label.Text = "";
            sql_connection.Open();
            var command = new SqlCommand("SELECT dbo.COUNT_OF_PRODUCTS(@ID) FROM Seller", sql_connection); // выручка для продавца
            command.Parameters.AddWithValue("@ID", id);
            count_of_product_label.Text = Convert.ToString(command.ExecuteScalar());        // заполняем label4 полученной информацией
            command.ExecuteNonQuery();
            sql_connection.Close();
        }

        // добавление нового товара
        private void new_product_button_Click(object sender, EventArgs e)
        {

            string word_pattern = @"[а-яё]+";
            string price_pattern = @"[\d]+";

            if (!Regex.IsMatch(product_name_textBox.Text, word_pattern, RegexOptions.IgnoreCase))
                MessageBox.Show("Введите корректное название.");

            else if (!Regex.IsMatch(product_price_textBox.Text, price_pattern))
                MessageBox.Show("Введите корректную цену.");

            else if (!Regex.IsMatch(category_textBox.Text, word_pattern, RegexOptions.IgnoreCase))
                MessageBox.Show("Введите корректную категорию.");
            else {
                var command = new SqlCommand("NEW_PRODUCT", sql_connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@NAME", product_name_textBox.Text);
                command.Parameters.AddWithValue("@PRICE", product_price_textBox.Text);
                command.Parameters.AddWithValue("@CATEGORY", category_textBox.Text);
                command.Parameters.AddWithValue("@SELLER_ID", id);
                sql_connection.Open();
                command.ExecuteNonQuery();
                sql_connection.Close();
            }

            product_name_textBox.Text = "";
            product_price_textBox.Text = "";
            category_textBox.Text = "";

            CountIncome();
            CountOfProd();
            FillingProductTable(); // обновляем таблицу товаров
        }

        // удалить товар
        private void delete_button_Click(object sender, EventArgs e)
        {
            string id_pattern = @"[\d]";

            if (!Regex.IsMatch(delete_id_textBox.Text, id_pattern))
                MessageBox.Show("Введите корректный id.");
            else {
                var command = new SqlCommand("DELETE_PRODUCT", sql_connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", delete_id_textBox.Text);
                sql_connection.Open();
                command.ExecuteNonQuery();
                sql_connection.Close();
            }

            delete_id_textBox.Text = "";

            CountIncome();
            CountOfProd();
            FillingProductTable(); // обновляем таблицу товаров
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

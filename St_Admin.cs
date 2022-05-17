using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace RZ
{
    public partial class St_Admin : Form
    {
        SqlConnection sql_connection;
        public string data;

        // конструктор формы
        public St_Admin(string data)
        {
            InitializeComponent();
            this.data = data;
            login_label.Text = data;
        }

        // функция вызывающаяся при загрузке формы
        private void St_Admin_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-S3IVENA\SQLEXPRESS;Initial Catalog=RZ_db;Integrated Security=True";
            sql_connection = new SqlConnection(connectionString);

            StaffTab();
        }

        // таблица сотрудников
        public void StaffTab()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            sql_connection.Open(); //Открыть подключение к БД
            var command = new SqlCommand("SELECT id, FIO AS \"ФИО\", email, login AS \"Логин\", password AS \"Пароль\", occupation AS \"Должность\" FROM Staff", sql_connection); //запрос на выполнение функции
            SqlDataReader sqlReader = null; //объявление ридера
            sqlReader = command.ExecuteReader(); //открытие ридера
            List<string[]> data = new List<string[]>(); //Объявляем список для записи данных
            for (int i = 0; i < 6; i++)
            { //Задаем названия столбцам
                dataGridView1.Columns.Add(i.ToString(), sqlReader.GetName(i));
            }
            while (sqlReader.Read()) // пока есть данные
            {
                data.Add(new string[6]); //Добавляем строку в список
                data[data.Count - 1][0] = sqlReader[0].ToString(); //Считываем данные
                data[data.Count - 1][1] = sqlReader[1].ToString();
                data[data.Count - 1][2] = sqlReader[2].ToString();
                data[data.Count - 1][3] = sqlReader[3].ToString();
                data[data.Count - 1][4] = sqlReader[4].ToString();
                data[data.Count - 1][5] = sqlReader[5].ToString();
            }
            foreach (string[] s in data) //Для каждого набора данных добавляем строку
                dataGridView1.Rows.Add(s);
            sqlReader.Close();//Закрываем ридер
            command.ExecuteNonQuery();
            sql_connection.Close();//Закрываем подключение
        }

        // новый сотрудник
        private void new_stuff_button_Click(object sender, EventArgs e)
        {

            #region Проверка существования логина
            sql_connection.Open();
            var command = new SqlCommand("SELECT COUNT(*) FROM Client WHERE LOGIN = @LOGIN", sql_connection);
            command.Parameters.AddWithValue("@LOGIN", login_textBox.Text);
            int client_login = (Int32)command.ExecuteScalar();
            command.ExecuteNonQuery();
            sql_connection.Close();

            sql_connection.Open();
            command = new SqlCommand("SELECT COUNT(*) FROM Seller WHERE LOGIN = @LOGIN", sql_connection);
            command.Parameters.AddWithValue("@LOGIN", login_textBox.Text);
            int seller_login = (Int32)command.ExecuteScalar();
            command.ExecuteNonQuery();
            sql_connection.Close();

            sql_connection.Open();
            command = new SqlCommand("SELECT COUNT(*) FROM Staff WHERE LOGIN = @LOGIN", sql_connection);
            command.Parameters.AddWithValue("@LOGIN", login_textBox.Text);
            int staff_login = (Int32)command.ExecuteScalar();
            command.ExecuteNonQuery();
            sql_connection.Close();
            #endregion

            string fio_pattern = @"^[А-ЯЁ][а-яё]* [А-ЯЁ][а-яё]* [А-ЯЁ][а-яё]*$";
            string email_pattern = @"(\w*)(\@{1})(\w*)(\.{1})(\w*)";

            if (!Regex.IsMatch(fio_textBox.Text, fio_pattern))
                MessageBox.Show("Введите корректные инициалы.");

            else if (!Regex.IsMatch(email_textBox.Text, email_pattern, RegexOptions.IgnoreCase))
                MessageBox.Show("Введите корректный email.");

            else if (login_textBox.TextLength == 0)
                MessageBox.Show("Поле \"" + new_login_label.Text + "\" не может быть пустым.");

            else if (client_login == 1 || seller_login == 1 || staff_login == 1)
                MessageBox.Show("Пользователь с таким логином уже существует.");

            else if (password_textBox.TextLength == 0)
                MessageBox.Show("Поле \"" + password_label.Text + "\" не может быть пустым.");

            else {
                command = new SqlCommand("NEW_STAFF", sql_connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("FIO", fio_textBox.Text);
                command.Parameters.AddWithValue("MAIL", email_textBox.Text);
                command.Parameters.AddWithValue("LOGIN", login_textBox.Text);
                command.Parameters.AddWithValue("PASSWORD", password_textBox.Text);

                if (admin_radioButton.Checked)
                    command.Parameters.AddWithValue("occupation", "Администратор");
                else
                    command.Parameters.AddWithValue("occupation", "Аналитик");
                sql_connection.Open();
                command.ExecuteNonQuery();
                sql_connection.Close();
            }

            fio_textBox.Text = "";
            email_textBox.Text = "";
            login_textBox.Text = "";
            password_textBox.Text = "";

            StaffTab();
        }

        // удалить сотрудника
        private void delete_stuff_button_Click(object sender, EventArgs e)
        {
            string id_pattern1 = @"[\d]";

            if (!Regex.IsMatch(delete_id_textBox.Text, id_pattern1)) 
                MessageBox.Show("Введите корректный id.");
            else
            {
                var command = new SqlCommand("DELETE_STAFF", sql_connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("id", delete_id_textBox.Text);
                sql_connection.Open();
                command.ExecuteNonQuery();
                sql_connection.Close();
            }

            delete_id_textBox.Text = "";

            StaffTab();
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

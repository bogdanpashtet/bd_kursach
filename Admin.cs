using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace RZ
{
    public partial class Admin : Form
    {

        SqlConnection sql_connection;
        public string data;

        // конструктор формы
        public Admin(string data)
        {
            InitializeComponent();
            this.data = data;
            login_label.Text = data;
        }

        // функция вызывающаяся при загрузке формы
        private void Admin_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-S3IVENA\SQLEXPRESS;Initial Catalog=RZ_db;Integrated Security=True";
            sql_connection = new SqlConnection(connectionString);


            sql_connection.Open(); //Открыть подключение к БД
            var command = new SqlCommand("SELECT id AS \"ID жалобы\", seller_id AS \"id Продавца\", complaint_text AS \"Текст жалобы\" FROM Complaint", sql_connection); //запрос на выполнение функции
            SqlDataReader sqlReader = null; //объявление ридера
            sqlReader = command.ExecuteReader(); //открытие ридера
            List<string[]> data = new List<string[]>(); //Объявляем список для записи данных
            for (int i = 0; i < 3; i++)
            { //Задаем названия столбцам
                dataGridView1.Columns.Add(i.ToString(), sqlReader.GetName(i));
            }
            while (sqlReader.Read()) // пока есть данные
            {
                data.Add(new string[3]); //Добавляем строку в список
                data[data.Count - 1][0] = sqlReader[0].ToString(); //Считываем данные
                data[data.Count - 1][1] = sqlReader[1].ToString();
                data[data.Count - 1][2] = sqlReader[2].ToString();
            }
            foreach (string[] s in data) //Для каждого набора данных добавляем строку
                dataGridView1.Rows.Add(s);
            sqlReader.Close();//Закрываем ридер
            command.ExecuteNonQuery();
            sql_connection.Close();//Закрываем подключение

            SellersTab();

        }

        // таблица продавцов
        public void SellersTab() {
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            sql_connection.Open(); 
            var command = new SqlCommand("SELECT id, FIO AS \"ФИО\", email, card_number AS \"Номер карты\", login  AS \"Логин\", password  AS \"Пароль\", phone_number  AS \"Номер телефона\", count_of_products  AS \"Количество товаров\", rating  AS \"Рейтинг продавца\", status  AS \"Статус\" FROM Seller;", sql_connection);
            SqlDataReader sqlReader = null; 
            sqlReader = command.ExecuteReader(); 
            List<string[]> data = new List<string[]>(); 
            for (int i = 0; i < 10; i++)
            { 
                dataGridView2.Columns.Add(i.ToString(), sqlReader.GetName(i));
            }
            while (sqlReader.Read()) 
            {
                data.Add(new string[10]); 
                data[data.Count - 1][0] = sqlReader[0].ToString(); 
                data[data.Count - 1][1] = sqlReader[1].ToString();
                data[data.Count - 1][2] = sqlReader[2].ToString();
                data[data.Count - 1][3] = sqlReader[3].ToString();
                data[data.Count - 1][4] = sqlReader[4].ToString();
                data[data.Count - 1][5] = sqlReader[5].ToString();
                data[data.Count - 1][6] = sqlReader[6].ToString();
                data[data.Count - 1][7] = sqlReader[7].ToString();
                data[data.Count - 1][8] = sqlReader[8].ToString();
                data[data.Count - 1][9] = sqlReader[9].ToString();
            }
            foreach (string[] s in data) 
                dataGridView2.Rows.Add(s);
            sqlReader.Close();
            command.ExecuteNonQuery();
            sql_connection.Close();
        }

        // заблокировать/разблокировать
        private void block_button_Click(object sender, EventArgs e)
        {
            string id_pattern = @"[\d]";

            if (!Regex.IsMatch(block_id_textBox.Text, id_pattern))
                MessageBox.Show("Введите корректный id.");
            else
            {
                var command = new SqlCommand("CHANGE_STATUS", sql_connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", block_id_textBox.Text);
                sql_connection.Open();
                command.ExecuteNonQuery();
                sql_connection.Close();
            }

            SellersTab();
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

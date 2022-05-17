using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RZ
{
    
    public partial class Analyst : Form
    {

        SqlConnection sql_connection;
        public string data;

        // конструктор формы
        public Analyst(string data)
        {
            InitializeComponent();
            this.data = data;
            login_label.Text = data;
        }
        
        // функция, вызывающаяся при загрузке формы
        private void Analyst_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-S3IVENA\SQLEXPRESS;Initial Catalog=RZ_db;Integrated Security=True";
            sql_connection = new SqlConnection(connectionString);

            CountIncome();

            sql_connection.Open(); //Открыть подключение к БД
            var command = new SqlCommand("SELECT * FROM t_ction", sql_connection); //запрос на выполнение функции
            SqlDataReader sqlReader = null; //объявление ридера
            sqlReader = command.ExecuteReader(); //открытие ридера
            List<string[]> data = new List<string[]>(); //Объявляем список для записи данных
            for (int i = 0; i < 7; i++)
            { //Задаем названия столбцам
                dataGridView1.Columns.Add(i.ToString(), sqlReader.GetName(i));
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
                dataGridView1.Rows.Add(s);
            sqlReader.Close();//Закрываем ридер
            command.ExecuteNonQuery();
            sql_connection.Close();//Закрываем подключение
        }
        
        // доход с сайта
        public void CountIncome()
        {
            income_label.Text = "";
            sql_connection.Open();
            var command = new SqlCommand("SELECT dbo.summary_cost_of_ANALYTIX() FROM _transaction", sql_connection); // выручка для продавца
            income_label.Text = Convert.ToString(command.ExecuteScalar());        // заполняем label4 полученной информацией
            command.ExecuteNonQuery();
            sql_connection.Close();
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

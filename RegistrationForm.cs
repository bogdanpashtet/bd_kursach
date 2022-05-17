using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace RZ
{
    public partial class RegistrationForm : Form
    {

        SqlConnection sql_connection;

        // конструктор формы
        public RegistrationForm()
        {
            InitializeComponent();
        }

        // функция, запускающаяся при загрузке формы
        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-S3IVENA\SQLEXPRESS;Initial Catalog=RZ_db;Integrated Security=True";
            sql_connection = new SqlConnection(connectionString);
        }

        // кнопка регистрации
        private void registration_button_Click(object sender, EventArgs e)
        {
            //Проверка ввода полей, создание новой записи клиента или продавца, переход к следующей форме

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
            string phone_number_pattern = @"\d{11}";
            string card_number_pattern = @"\d{16}";

            if (!Regex.IsMatch(fio_textBox.Text, fio_pattern))
                MessageBox.Show("Введите корректные инициалы.");

            else if (!Regex.IsMatch(mail_textBox.Text, email_pattern, RegexOptions.IgnoreCase))
                MessageBox.Show("Введите корректный email.");
            
            else if (!Regex.IsMatch(phone_number_textBox.Text, phone_number_pattern))
                MessageBox.Show("Введите корректный номер телефона.");
            
            else if (!Regex.IsMatch(card_number_textBox.Text, card_number_pattern))
                MessageBox.Show("Введите корректный номер карты.");
           
            else if (login_textBox.TextLength == 0)
                MessageBox.Show("Поле \"" + login_label.Text + "\" не может быть пустым.");
            
            else if (client_login ==  1 || seller_login == 1 || staff_login == 1)
                MessageBox.Show("Пользователь с таким логином уже существует.");
            
            else if (password_textBox.TextLength == 0)
                MessageBox.Show("Поле \"" + password_label.Text + "\" не может быть пустым.");
            
            else
            {
                if (client_radioButton.Checked) // если radiobutton1 выбрано, то задаем клиента
                {
                    command = new SqlCommand("NEW_CLIENT", sql_connection);
                    command.CommandType = CommandType.StoredProcedure;   
                }
                else {  // иначе продавца
                    command = new SqlCommand("NEW_SELLER", sql_connection);
                    command.CommandType = CommandType.StoredProcedure; 
                }
                command.Parameters.AddWithValue("FIO", fio_textBox.Text);
                command.Parameters.AddWithValue("MAIL", mail_textBox.Text);
                command.Parameters.AddWithValue("PHONE_NUMBER", phone_number_textBox.Text);
                command.Parameters.AddWithValue("CARD_NUMBER", card_number_textBox.Text);
                command.Parameters.AddWithValue("LOGIN", login_textBox.Text);
                command.Parameters.AddWithValue("PASSWORD", password_textBox.Text);
                sql_connection.Open();
                command.ExecuteNonQuery();
                sql_connection.Close();

                MessageBox.Show("Регистрация пройдена успешно.");

                Form startForm = new StartForm(); //Открытие стартовой формы 
                startForm.Show();
                this.Hide();
            }
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

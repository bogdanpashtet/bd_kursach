using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RZ
{
    public partial class StartForm : Form
    {

        SqlConnection sql_connection;

        // конструктор формы
        public StartForm()
        {
            InitializeComponent();
        }

        // функция, вызываемая при загрузке формы
        private void StartForm_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-S3IVENA\SQLEXPRESS;Initial Catalog=RZ_db;Integrated Security=True";
            sql_connection = new SqlConnection(connectionString);
        }

        // кнопка входа
        private void enter_button_Click(object sender, EventArgs e)
        {

            if (login_textBox.TextLength == 0) 
                MessageBox.Show("Введите логин");
            else if (password_textBox.TextLength == 0) 
                MessageBox.Show("Введите пароль.");
            else //Если оба поля заполнены
            {
                #region Clients
                int is_Cl_exists = -1; 

                sql_connection.Open(); 
                var command = new SqlCommand("SELECT COUNT(*) FROM Client WHERE (LOGIN = @LOGIN) AND (PASSWORD = @PASSWORD)", sql_connection); 
                command.Parameters.AddWithValue("@LOGIN", login_textBox.Text);
                command.Parameters.AddWithValue("@PASSWORD", password_textBox.Text);
                is_Cl_exists = (Int32)command.ExecuteScalar(); 
                command.ExecuteNonQuery(); 
                sql_connection.Close(); 
                
                #endregion

                #region Seller
                int is_Se_exists = -1; 

                sql_connection.Open(); 
                command = new SqlCommand("SELECT COUNT(*) FROM Seller WHERE (LOGIN = @LOGIN) AND (PASSWORD = @PASSWORD)", sql_connection); 
                command.Parameters.AddWithValue("@LOGIN", login_textBox.Text);
                command.Parameters.AddWithValue("@PASSWORD", password_textBox.Text);
                is_Se_exists = (Int32)command.ExecuteScalar(); 
                command.ExecuteNonQuery(); 
                sql_connection.Close();
                
                #endregion

                #region Staff
                int is_St_exists = -1; 

                sql_connection.Open(); 
                command = new SqlCommand("SELECT COUNT(*) FROM Staff WHERE (LOGIN = @LOGIN) AND (PASSWORD = @PASSWORD)", sql_connection); 
                command.Parameters.AddWithValue("@LOGIN", login_textBox.Text);
                command.Parameters.AddWithValue("@PASSWORD", password_textBox.Text);
                is_St_exists = (Int32)command.ExecuteScalar(); 
                command.ExecuteNonQuery(); 
                sql_connection.Close();

                #endregion

                if (is_Cl_exists == 1) 
                {
                    Form client_cabinet = new Client_Cabinet(this.login_textBox.Text); 
                    client_cabinet.Show();
                    this.Hide();
                }
                else if (is_Se_exists == 1)
                {

                    sql_connection.Open();
                    command = new SqlCommand("SELECT status FROM Seller WHERE LOGIN = @LOGIN", sql_connection);
                    command.Parameters.AddWithValue("@LOGIN", login_textBox.Text);
                    int status = (Int32)command.ExecuteScalar();
                    command.ExecuteNonQuery();
                    sql_connection.Close();

                    if (status == 0)
                    {
                        Form seller_cabinet = new Seller_Cabinet(this.login_textBox.Text); 
                        seller_cabinet.Show();
                        this.Hide();
                    }
                    else {
                        MessageBox.Show("Вы заблокированы на данном ресурсе.");
                    }

                }
                else if (is_St_exists == 1)
                {

                    sql_connection.Open();
                    command = new SqlCommand("SELECT occupation FROM Staff WHERE LOGIN = @LOGIN", sql_connection);
                    command.Parameters.AddWithValue("@LOGIN", login_textBox.Text);
                    string occ = Convert.ToString(command.ExecuteScalar());
                    command.ExecuteNonQuery();
                    sql_connection.Close();

                    if (occ == "Аналитик")
                    {
                        Form analyst_cabinet = new Analyst(this.login_textBox.Text); 
                        analyst_cabinet.Show();
                        this.Hide();
                    }
                    else if (occ == "Администратор")
                    {
                        Form admin_cabinet = new Admin(this.login_textBox.Text); 
                        admin_cabinet.Show();
                        this.Hide();
                    }
                    else {
                        Form st_admin_cabinet = new St_Admin(this.login_textBox.Text); 
                        st_admin_cabinet.Show();
                        this.Hide();
                    }

                    
                }
                else
                    MessageBox.Show("Неверный логин или пароль.");
            }

        }

        // кнопка регистрации
        private void registration_button_Click(object sender, EventArgs e)
        {
            Form RegForm = new RegistrationForm(); 
            RegForm.Show();
            this.Hide();
        }
    }
}

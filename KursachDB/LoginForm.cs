using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KursachDB
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public delegate void checkLogin(bool action);
        public event checkLogin LoginTrue;

        private bool checkLoginAndPassword(string Login, string Password)
        {
            bool Valid;
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["KursachDB.Properties.Settings.GameLibraryConnectionString"].ConnectionString))
            {
                con.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE UserLogin = @Login AND UserPassword = @Password");
                command.Connection = con;
                command.Parameters.AddWithValue("@Login", Login);
                command.Parameters.AddWithValue("@Password", Password);
                SqlDataReader dataReader = command.ExecuteReader();
                Valid = dataReader.Read();
                
                con.Close();
            }
            return Valid;
            
        }

        public void changeEnablePravka()
        {
            bool action = true;
            LoginTrue(action);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.TextLength == 0 || textBox2.TextLength == 0)
                {
                    throw new Exception("Введите данные");
                }
                else
                {
                    bool Valid = checkLoginAndPassword(textBox1.Text, textBox2.Text);
                    if (Valid)
                    {
                        changeEnablePravka();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Плохо:С", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

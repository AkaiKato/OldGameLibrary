using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Configuration;
using System.Windows.Forms;

namespace KursachDB
{
    public partial class AddForm : Form
    {
        string nameOfTable;
        public AddForm(string nameOfTable)
        {
            InitializeComponent();
            this.nameOfTable = nameOfTable;
            switch (nameOfTable)
            {
                case "Games":
                    break;
                case "Achievements":
                    groupBox1.Text = "Добавление достижения";
                    label1.Text = "ID Достижения";
                    label1.Location = new Point(6,37);
                    textBox1.Location = new Point(223, 34);
                    label2.Text = "ID Коллекции достижений";
                    label2.Location = new Point(6, 69);
                    textBox2.Location = new Point(223, 66);
                    label3.Text = "Название достижения";
                    textBox3.Location = new Point(223, 98);
                    label3.Location = new Point(6, 101);
                    label4.Text = "Дата получения";
                    label4.Location = new Point(6, 133);
                    dateTimePicker1.Location = new Point(223, 130);
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
                    textBox5.Visible = false;
                    textBox6.Visible = false;
                    textBox4.Visible = false;
                    textBox7.Visible = false;
                    textBox8.Visible = false;
                    break;
                case "Developers":
                    groupBox1.Text = "Добавление разработчика";
                    label1.Text = "ID Разработчика";
                    label1.Location = new Point(6, 37);
                    textBox1.Location = new Point(223, 34);
                    label2.Text = "Имя разработчика";
                    label2.Location = new Point(6, 69);
                    textBox2.Location = new Point(223, 66);
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    dateTimePicker1.Visible = false;
                    textBox3.Visible = false;
                    textBox5.Visible = false;
                    textBox6.Visible = false;
                    textBox4.Visible = false;
                    textBox7.Visible = false;
                    textBox8.Visible = false;
                    break;
                case "Genres":
                    groupBox1.Text = "Добавление жанра";
                    label1.Text = "Название жанра";
                    label1.Location = new Point(6, 37);
                    textBox1.Location = new Point(223, 34);
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    dateTimePicker1.Visible = false;
                    textBox2.Visible = false;
                    textBox3.Visible = false;
                    textBox5.Visible = false;
                    textBox6.Visible = false;
                    textBox4.Visible = false;
                    textBox7.Visible = false;
                    textBox8.Visible = false;
                    break;
                case "Publishers":
                    groupBox1.Text = "Добавление Издателя";
                    label1.Text = "ID Издателя";
                    label1.Location = new Point(6, 37);
                    textBox1.Location = new Point(223, 34);
                    label2.Text = "Имя издателя";
                    label2.Location = new Point(6, 69);
                    textBox2.Location = new Point(223, 66);
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    dateTimePicker1.Visible = false;
                    textBox3.Visible = false;
                    textBox5.Visible = false;
                    textBox6.Visible = false;
                    textBox4.Visible = false;
                    textBox7.Visible = false;
                    textBox8.Visible = false;
                    break;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = this.Owner as MainForm;
            DataRow dataRowGames = mainForm.tableDataSet.Games.NewRow();
            DataRow dataRowColl = mainForm.tableDataSet.CollAchievements.NewRow();
            DataRow dataRowGenre = mainForm.tableDataSet.Genre.NewRow();
            DataRow dataRowPublisher = mainForm.tableDataSet.Publishers.NewRow();
            DataRow dataRowDeveloper = mainForm.tableDataSet.Developers.NewRow();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["KursachDB.Properties.Settings.GameLibraryConnectionString"].ConnectionString);
            bool Valid;
            try
            {
                switch (nameOfTable)
                {
                    case "Games":
                        {
                            bool uniqueColl = true, uniqueID = true;

                            for (int i = 0; i < mainForm.dataGridView1.Rows.Count; i++)
                            {
                                if (mainForm.dataGridView1.Rows[i].Cells[1].Value.ToString().Contains(textBox1.Text))
                                    uniqueColl = false;
                            }
                            if (!uniqueColl)
                                throw new Exception("Не уникальное значение CollAchievementsID");

                            for (int i = 0; i < mainForm.dataGridView1.Rows.Count; i++)
                            {
                                if (mainForm.dataGridView1.Rows[i].Cells[0].Value.ToString().Contains(textBox8.Text))
                                    uniqueID = false;
                            }
                            if (!uniqueID)
                            {
                                throw new Exception("Не укникальное значение GameID");
                            }

                            dataRowGames[0] = textBox8.Text;
                            dataRowGames[1] = textBox1.Text;
                            dataRowGames[2] = textBox2.Text;
                            dataRowGames[3] = textBox3.Text;
                            dataRowGames[4] = dateTimePicker1.Value.ToString();
                            dataRowGames[5] = textBox4.Text;
                            dataRowGames[6] = textBox5.Text;

                            dataRowColl[0] = textBox1.Text;

                            dataRowGenre[0] = textBox3.Text;

                            dataRowDeveloper[0] = textBox5.Text;
                            dataRowDeveloper[1] = textBox6.Text;

                            dataRowPublisher[0] = textBox4.Text;
                            dataRowPublisher[1] = textBox7.Text;

                            con.Open();
                            SqlCommand commandGenre = new SqlCommand("SELECT * FROM Genre WHERE Genre = @Genre");
                            commandGenre.Connection = con;
                            commandGenre.Parameters.AddWithValue("@Genre", textBox3.Text);
                            SqlDataReader dataReaderGenre = commandGenre.ExecuteReader();
                            Valid = dataReaderGenre.Read();
                            if (!Valid)
                            {
                                mainForm.tableDataSet.Genre.Rows.Add(dataRowGenre);
                                mainForm.genresAdapter.Update(mainForm.tableDataSet.Genre);
                            }
                            con.Close();

                            con.Open();
                            SqlCommand commandColl = new SqlCommand("SELECT * FROM CollAchievements WHERE CollAchievementsID = @CollAchievements");
                            commandColl.Connection = con;
                            commandColl.Parameters.AddWithValue("@CollAchievements", textBox1.Text);
                            SqlDataReader dataReaderColl = commandColl.ExecuteReader();
                            Valid = dataReaderColl.Read();
                            if (!Valid)
                            {
                                mainForm.tableDataSet.CollAchievements.Rows.Add(dataRowColl);
                                mainForm.collAdapter.Update(mainForm.tableDataSet.CollAchievements);
                            }
                            con.Close();

                            con.Open();
                            SqlCommand commandPublisher = new SqlCommand("SELECT * FROM Publishers WHERE PublisherID = @PublisherID OR Publisher = @Publisher");
                            commandPublisher.Connection = con;
                            commandPublisher.Parameters.AddWithValue("@PublisherID", textBox4.Text);
                            commandPublisher.Parameters.AddWithValue("@Publisher", textBox7.Text);
                            SqlDataReader dataReaderPublisher = commandPublisher.ExecuteReader();
                            Valid = dataReaderPublisher.Read();
                            if (!Valid)
                            {
                                mainForm.tableDataSet.Publishers.Rows.Add(dataRowPublisher);
                                mainForm.publishersAdapter.Update(mainForm.tableDataSet.Publishers);
                            }
                            con.Close();

                            con.Open();
                            SqlCommand commandDeveloper = new SqlCommand("SELECT * FROM Developers WHERE DeveloperID = @DeveloperID OR Developer = @Developer");
                            commandDeveloper.Connection = con;
                            commandDeveloper.Parameters.AddWithValue("@DeveloperID", textBox5.Text);
                            commandDeveloper.Parameters.AddWithValue("@Developer", textBox6.Text);
                            SqlDataReader dataReaderDeveloper = commandDeveloper.ExecuteReader();
                            Valid = dataReaderDeveloper.Read();
                            if (!Valid)
                            {
                                mainForm.tableDataSet.Developers.Rows.Add(dataRowDeveloper);
                                mainForm.developersAdapter.Update(mainForm.tableDataSet.Developers);
                            }
                            con.Close();

                            mainForm.tableDataSet.Games.Rows.Add(dataRowGames);
                            mainForm.gamesAdapter.Update(mainForm.tableDataSet.Games);
                            mainForm.dataGridView1.Refresh();
                            break;
                        }
                    case "Achievements":
                        {
                            DataRow dataRowAchievement = mainForm.tableDataSet.Achievements.NewRow();
                            bool uniqueAch = true;
                            for (int i = 0; i < mainForm.dataGridView1.Rows.Count; i++)
                            {
                                if (mainForm.dataGridView1.Rows[i].Cells[0].Value.ToString().Contains(textBox1.Text))
                                    uniqueAch = false;
                            }
                            if (!uniqueAch)
                                throw new Exception("Не укникальное значение AchievementsID");

                            dataRowAchievement[0] = textBox1.Text;
                            dataRowAchievement[1] = textBox2.Text;
                            dataRowAchievement[2] = textBox3.Text;
                            dataRowAchievement[3] = dateTimePicker1.Value.ToString();

                            mainForm.tableDataSet.Achievements.Rows.Add(dataRowAchievement);
                            mainForm.achievementsAdapter.Update(mainForm.tableDataSet.Achievements);
                            break;
                        }
                    case "Developers":
                        {
                            dataRowDeveloper[0] = textBox1.Text;
                            dataRowDeveloper[1] = textBox2.Text;

                            con.Open();
                            SqlCommand commandDeveloper1 = new SqlCommand("SELECT * FROM Developers WHERE DeveloperID = @DeveloperID OR Developer = @Developer");
                            commandDeveloper1.Connection = con;
                            commandDeveloper1.Parameters.AddWithValue("@DeveloperID", textBox1.Text);
                            commandDeveloper1.Parameters.AddWithValue("@Developer", textBox2.Text);
                            SqlDataReader dataReaderDeveloper1 = commandDeveloper1.ExecuteReader();
                            Valid = dataReaderDeveloper1.Read();
                            con.Close();
                            if (!Valid)
                            {
                                mainForm.tableDataSet.Developers.Rows.Add(dataRowDeveloper);
                                mainForm.developersAdapter.Update(mainForm.tableDataSet.Developers);
                            }
                            else
                            {
                                throw new Exception("Не уникальные значения DeveloperID или Developer");
                            }
                            break;
                        }
                    case "Genres":
                        {
                            dataRowGenre[0] = textBox1.Text;

                            con.Open();
                            SqlCommand commandGenre1 = new SqlCommand("SELECT * FROM Genre WHERE Genre = @Genre");
                            commandGenre1.Connection = con;
                            commandGenre1.Parameters.AddWithValue("@Genre", textBox1.Text);
                            SqlDataReader dataReaderGenre1 = commandGenre1.ExecuteReader();
                            Valid = dataReaderGenre1.Read();
                            con.Close();
                            if (!Valid)
                            {
                                mainForm.tableDataSet.Genre.Rows.Add(dataRowGenre);
                                mainForm.genresAdapter.Update(mainForm.tableDataSet.Genre);
                            }
                            else
                            {
                                throw new Exception("Не уникальные значение Genre");
                            }
                            break;
                        }
                    case "Publishers":
                        {
                            dataRowPublisher[0] = textBox1.Text;
                            dataRowPublisher[1] = textBox2.Text;

                            con.Open();
                            SqlCommand commandPublisher1 = new SqlCommand("SELECT * FROM Publishers WHERE PublisherID = @PublisherID OR Publisher = @Publisher");
                            commandPublisher1.Connection = con;
                            commandPublisher1.Parameters.AddWithValue("@PublisherID", textBox1.Text);
                            commandPublisher1.Parameters.AddWithValue("@Publisher", textBox2.Text);
                            SqlDataReader dataReaderPublisher1 = commandPublisher1.ExecuteReader();
                            Valid = dataReaderPublisher1.Read();
                            con.Close();
                            if (!Valid)
                            {
                                mainForm.tableDataSet.Publishers.Rows.Add(dataRowPublisher);
                                mainForm.publishersAdapter.Update(mainForm.tableDataSet.Publishers);
                            }
                            else
                            {
                                throw new Exception("Не уникальные значения PublisherID или Publisher");
                            }
                            break;
                        }
                }
                textBox1.Text = textBox2.Text = textBox3.Text = textBox5.Text = textBox6.Text = textBox4.Text = textBox7.Text = textBox8.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

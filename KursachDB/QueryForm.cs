using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace KursachDB
{
    public partial class QueryForm : Form
    {
        string nameOfQuery;
        private SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["KursachDB.Properties.Settings.GameLibraryConnectionString"].ConnectionString);
        public QueryForm(string nameOfQuery)
        {
            InitializeComponent();
            this.nameOfQuery = nameOfQuery;
            switch (nameOfQuery)
            {
                case "allGamesOneDeveloper":
                    break;
                case "allGamesOnePublisher":
                    label1.Text = "Введите имя издателя";
                    groupBox1.Text = "Все игры одного издателя";
                    break;
                case "allGamesOneGenre":
                    label1.Text = "Введите название жанра";
                    groupBox1.Text = "Все игры одного жанра";
                    break;
                case "allGamesOneYear":
                    label1.Text = "Введите год";
                    groupBox1.Text = "Все игры одного года";
                    break;
                case "allAchievemntsOneGame":
                    label1.Text = "Введите название игры";
                    groupBox1.Text = "Все достижения одной игры";
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = this.Owner as MainForm;
            try
            {
                string strCommand = "";
                con.Open();
                switch (nameOfQuery)
                {
                    case "allGamesOneDeveloper":
                        strCommand = "SELECT GameID, GameName, Genre, ReleaseYear, Developer FROM dbo.Games join dbo.Developers on Games.DeveloperID = Developers.DeveloperID WHERE Developers.Developer = '" + textBox1.Text + "'";
                        SqlDataAdapter adapterOneDeveloper = new SqlDataAdapter(strCommand, con);
                        DataSet dsOneDeveloper = new DataSet();
                        adapterOneDeveloper.Fill(dsOneDeveloper);
                        mainForm.dataGridView1.DataSource = null;
                        mainForm.dataGridView1.DataSource = dsOneDeveloper.Tables[0];
                        mainForm.dataGridView1.Sort(mainForm.dataGridView1.Columns[0], 0);
                        con.Close();
                        break;
                    case "allGamesOnePublisher":
                        strCommand = "SELECT GameID, GameName, Genre, ReleaseYear, Publisher FROM dbo.Games join dbo.Publishers on Games.PublisherID = Publishers.PublisherID WHERE Publishers.Publisher = '" + textBox1.Text + "'";
                        SqlDataAdapter adapterOnePublisher = new SqlDataAdapter(strCommand, con);
                        DataSet dsOnePublisher = new DataSet();
                        adapterOnePublisher.Fill(dsOnePublisher);
                        mainForm.dataGridView1.DataSource = null;
                        mainForm.dataGridView1.DataSource = dsOnePublisher.Tables[0];
                        mainForm.dataGridView1.Sort(mainForm.dataGridView1.Columns[0], 0);
                        con.Close();
                        break;
                    case "allGamesOneGenre":
                        strCommand = "SELECT GameID, GameName, Genre.Genre, ReleaseYear FROM dbo.Games join dbo.Genre on Games.Genre = Genre.Genre WHERE Genre.Genre = '" + textBox1.Text + "'";
                        SqlDataAdapter adapterOnePGenre = new SqlDataAdapter(strCommand, con);
                        DataSet dsOneGenre = new DataSet();
                        adapterOnePGenre.Fill(dsOneGenre);
                        mainForm.dataGridView1.DataSource = null;
                        mainForm.dataGridView1.DataSource = dsOneGenre.Tables[0];
                        mainForm.dataGridView1.Sort(mainForm.dataGridView1.Columns[0], 0);
                        con.Close();
                        break;
                    case "allGamesOneYear":
                        strCommand = "Select GameID, GameName, Genre, ReleaseYear FROM Games where Year(ReleaseYear) = " + textBox1.Text;
                        SqlDataAdapter adapterOneYear = new SqlDataAdapter(strCommand, con);
                        DataSet dsOneYear = new DataSet();
                        adapterOneYear.Fill(dsOneYear);
                        mainForm.dataGridView1.DataSource = null;
                        mainForm.dataGridView1.DataSource = dsOneYear.Tables[0];
                        mainForm.dataGridView1.Sort(mainForm.dataGridView1.Columns[0], 0);
                        con.Close();
                        break;
                    case "allAchievemntsOneGame":
                        strCommand = "Select GameID, GameName, NameOfAchievement, DateOfGetting  FROM Games join Achievements on Games.CollAchievementsID = Achievements.CollAchievementsID WHERE Games.GameName = '" + textBox1.Text + "'";
                        SqlDataAdapter adapterAllAchievementsOneGame = new SqlDataAdapter(strCommand, con);
                        DataSet dsAllAchievementsOneGame = new DataSet();
                        adapterAllAchievementsOneGame.Fill(dsAllAchievementsOneGame);
                        mainForm.dataGridView1.DataSource = null;
                        mainForm.dataGridView1.DataSource = dsAllAchievementsOneGame.Tables[0];
                        mainForm.dataGridView1.Sort(mainForm.dataGridView1.Columns[0], 0);
                        con.Close();
                        break;
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка запроса.\nТекст ошибки: " + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*this.Close();*/
        }
    }
}

using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace KursachDB
{
    public partial class MainForm : Form
    {
        public GameLibraryDataSet tableDataSet = new GameLibraryDataSet();
        public GameLibraryDataSetTableAdapters.GamesTableAdapter gamesAdapter = new GameLibraryDataSetTableAdapters.GamesTableAdapter();
        public GameLibraryDataSetTableAdapters.CollAchievementsTableAdapter collAdapter = new GameLibraryDataSetTableAdapters.CollAchievementsTableAdapter();
        public GameLibraryDataSetTableAdapters.AchievementsTableAdapter achievementsAdapter = new GameLibraryDataSetTableAdapters.AchievementsTableAdapter();
        public GameLibraryDataSetTableAdapters.DevelopersTableAdapter developersAdapter = new GameLibraryDataSetTableAdapters.DevelopersTableAdapter();
        public GameLibraryDataSetTableAdapters.GenreTableAdapter genresAdapter = new GameLibraryDataSetTableAdapters.GenreTableAdapter();
        public GameLibraryDataSetTableAdapters.PublishersTableAdapter publishersAdapter = new GameLibraryDataSetTableAdapters.PublishersTableAdapter();

        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["KursachDB.Properties.Settings.GameLibraryConnectionString"].ConnectionString);

        public string nameOfTable;
        public MainForm()
        {
            InitializeComponent();
            правкаToolStripMenuItem.Enabled = false; 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm logForm = new LoginForm();
            logForm.LoginTrue += changePravkaToolStripMenuItem;
            logForm.ShowDialog();
            
        } 
        public void changePravkaToolStripMenuItem(bool action)
        {
            this.правкаToolStripMenuItem.Enabled = true;
        }

        public void Extract_Data_From_DB(string tableName)
        {
            dataGridView1.DataSource = null;
            switch (tableName)
            {
                case "Games":
                    gamesAdapter.Fill(tableDataSet.Games);
                    dataGridView1.DataSource = tableDataSet.Games;
                    break;
                case "Achievements":
                    achievementsAdapter.Fill(tableDataSet.Achievements);
                    dataGridView1.DataSource = tableDataSet.Achievements;
                    break;
                case "Developers":
                    developersAdapter.Fill(tableDataSet.Developers);
                    dataGridView1.DataSource = tableDataSet.Developers;
                    break;
                case "Genres":
                    genresAdapter.Fill(tableDataSet.Genre);
                    dataGridView1.DataSource = tableDataSet.Genre;
                    break;
                case "Publishers":
                    publishersAdapter.Fill(tableDataSet.Publishers);
                    dataGridView1.DataSource = tableDataSet.Publishers;
                    break;
            }
        }

        private void Games_Click(object sender, EventArgs e)
        {
            Games.Enabled = false;
            Achievements.Enabled = true;
            Developers.Enabled = true;
            Genre.Enabled = true;
            Publishers.Enabled = true;
            nameOfTable = "Games";
            Extract_Data_From_DB(nameOfTable);
        }

        private void Achievements_Click(object sender, EventArgs e)
        {
            Games.Enabled = true;
            Achievements.Enabled = false;
            Developers.Enabled = true;
            Genre.Enabled = true;
            Publishers.Enabled = true;
            nameOfTable = "Achievements";
            Extract_Data_From_DB(nameOfTable);
        }

        private void Genre_Click(object sender, EventArgs e)
        {
            Games.Enabled = true;
            Achievements.Enabled = true;
            Developers.Enabled = true;
            Genre.Enabled = false;
            Publishers.Enabled = true;
            nameOfTable = "Genres";
            Extract_Data_From_DB(nameOfTable);
        }

        private void Developers_Click(object sender, EventArgs e)
        {
            Games.Enabled = true;
            Achievements.Enabled = true;
            Developers.Enabled = false;
            Genre.Enabled = true;
            Publishers.Enabled = true;
            nameOfTable = "Developers";
            Extract_Data_From_DB(nameOfTable);
        }

        private void Publishers_Click(object sender, EventArgs e)
        {
            Games.Enabled = true;
            Achievements.Enabled = true;
            Developers.Enabled = true;
            Genre.Enabled = true;
            Publishers.Enabled = false;
            nameOfTable = "Publishers";
            Extract_Data_From_DB(nameOfTable);
        }

        private void найтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameOfTable == null)
                    throw new Exception("Выберите таблицу");
                SearchForm searchForm = new SearchForm(nameOfTable);
                searchForm.Owner = this;
                searchForm.Show();
                Extract_Data_From_DB(nameOfTable);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void добавитьИгруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameOfTable == null)
                    throw new Exception("Выберите таблицу");
                else
                {
                    AddForm addForm = new AddForm(nameOfTable);
                    addForm.Owner = this;
                    addForm.Show();
                    Extract_Data_From_DB(nameOfTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void изменитьИгруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameOfTable == null)
                    throw new Exception("Выберите таблицу");
                if (nameOfTable == "Genres")
                    MessageBox.Show("Таблица Жанров содержит только один столбец, все элементы которого - первичные ключи. Редактирование невозможно", "Редактирование невозможно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    switch (nameOfTable)
                    {
                        case "Games":
                            DialogResult dialogResultGames = MessageBox.Show("Редактировать запись?\n", "Редактировать", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                            if(dialogResultGames == DialogResult.OK)
                            {
                                ChangeForm changeForm = new ChangeForm(nameOfTable, ((DataRowView)dataGridView1.CurrentRow.DataBoundItem).Row);
                                changeForm.Owner = this;
                                changeForm.Show();
                            }
                            break;
                        case "Achievements":
                            DialogResult dialogResultAchievements = MessageBox.Show("Редактировать запись?\n", "Редактировать", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                            if (dialogResultAchievements == DialogResult.OK)
                            {
                                ChangeForm changeForm = new ChangeForm(nameOfTable, ((DataRowView)dataGridView1.CurrentRow.DataBoundItem).Row);
                                changeForm.Owner = this;
                                changeForm.Show();
                            }
                            break;
                        case "Developers":
                            DialogResult dialogResultDevelopers = MessageBox.Show("Редактировать запись?\n", "Редактировать", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                            if (dialogResultDevelopers == DialogResult.OK)
                            {
                                ChangeForm changeForm = new ChangeForm(nameOfTable, ((DataRowView)dataGridView1.CurrentRow.DataBoundItem).Row);
                                changeForm.Owner = this;
                                changeForm.Show();
                            }
                            break;
                        case "Publishers":
                            DialogResult dialogResultPublishers = MessageBox.Show("Редактировать запись?\n", "Редактировать", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                            if (dialogResultPublishers == DialogResult.OK)
                            {
                                ChangeForm changeForm = new ChangeForm(nameOfTable, ((DataRowView)dataGridView1.CurrentRow.DataBoundItem).Row);
                                changeForm.Owner = this;
                                changeForm.Show();
                            }
                            break;
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void удалитьИгруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameOfTable == null)
                    throw new Exception("Выберите таблицу");
                else
                {
                    switch (nameOfTable)
                    {
                        case "Games":
                            if (dataGridView1.Rows.Count == 0)
                                throw new Exception("Таблица пуста");
                            DialogResult dialogResultGames = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                            if(dialogResultGames == DialogResult.OK)
                            {
                                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                            }
                            gamesAdapter.Update(tableDataSet.Games);
                            break;
                        case "Achievements":
                            if (dataGridView1.Rows.Count == 0)
                                throw new Exception("Таблица пуста");
                            DialogResult dialogResultAcievements = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                            if (dialogResultAcievements == DialogResult.OK)
                            {
                                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                            }
                            achievementsAdapter.Update(tableDataSet.Achievements);
                            break;
                        case "Developers":
                            if (dataGridView1.Rows.Count == 0)
                                throw new Exception("Таблица пуста");
                            DialogResult dialogResultDevelopers = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                            if (dialogResultDevelopers == DialogResult.OK)
                            {
                                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                            }
                            developersAdapter.Update(tableDataSet.Developers);
                            break;
                        case "Genres":
                            if (dataGridView1.Rows.Count == 0)
                                throw new Exception("Таблица пуста");
                            DialogResult dialogResultGenres = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                            if (dialogResultGenres == DialogResult.OK)
                            {
                                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                            }
                            genresAdapter.Update(tableDataSet.Genre);
                            break;
                        case "Publishers":
                            if (dataGridView1.Rows.Count == 0)
                                throw new Exception("Таблица пуста");
                            DialogResult dialogResultPublishers = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                            if (dialogResultPublishers == DialogResult.OK)
                            {
                                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                            }
                            publishersAdapter.Update(tableDataSet.Publishers);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void всеИгрыРазработчикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QueryForm queryForm = new QueryForm("allGamesOneDeveloper");
            queryForm.Owner = this;
            queryForm.Show();
        }

        private void всеИгрыИздателяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QueryForm queryForm = new QueryForm("allGamesOnePublisher");
            queryForm.Owner = this;
            queryForm.Show();
        }

        private void всеИгрыВОпределенномЖанреToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QueryForm queryForm = new QueryForm("allGamesOneGenre");
            queryForm.Owner = this;
            queryForm.Show();
        }

        private void всеИгрыЗаОпределенныйГодToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QueryForm queryForm = new QueryForm("allGamesOneYear");
            queryForm.Owner = this;
            queryForm.Show();
        }

        private void достиженияОднойИгрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QueryForm queryForm = new QueryForm("allAchievemntsOneGame");
            queryForm.Owner = this;
            queryForm.Show();
        }
    }
}

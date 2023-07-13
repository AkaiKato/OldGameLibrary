using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace KursachDB
{
    public partial class SearchForm : Form
    {
        string nameOfTable;
        public SearchForm(string nameOfTable)
        {
            InitializeComponent();
            searchBtn.Enabled = false;
            this.nameOfTable = nameOfTable;
            switch (nameOfTable)
            {
                case "Games":
                    groupBox1.Text = "Поиск игры";
                    label1.Location = new Point(79, 40);
                    label1.Text = "Введите название игры";
                    break;
                case "Achievements":
                    groupBox1.Text = "Поиск достижения";
                    label1.Location = new Point(40, 40);
                    label1.Text = "Введите название достижения";
                    break;
                case "Developers":
                    groupBox1.Text = "Поиск разработчика";
                    label1.Location = new Point(65, 40);
                    label1.Text = "Введите имя разработчика";
                    break;
                case "Genres":
                    groupBox1.Text = "Поиск жанра";
                    label1.Location = new Point(75, 40);
                    label1.Text = "Введите название жанра";
                    break;
                case "Publishers":
                    groupBox1.Text = "Поиск издателя";
                    label1.Location = new Point(120, 40);
                    label1.Text = "Введите издателя";
                    break;
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MainForm mainForm = this.Owner as MainForm;
                if (mainForm != null)
                {
                    mainForm.dataGridView1.ClearSelection();
                    switch (nameOfTable)
                    {
                        case "Games":
                            List<int> indexGames = new List<int>();
                            if (textBox1.Text != "")
                            {
                                for (int i = 0; i < mainForm.dataGridView1.Rows.Count; i++)
                                {
                                    if (mainForm.dataGridView1.Rows[i].Cells[2].Value.ToString().Contains(textBox1.Text))
                                        indexGames.Add(i);
                                }
                            }
                            if(indexGames.Count != 0)
                                mainForm.dataGridView1.Rows[indexGames.First()].Selected = true;
                            else
                                MessageBox.Show("Запись не найдена");
                            break;
                        case "Achievements":
                            List<int> indexAchievements = new List<int>();
                            if (textBox1.Text != "")
                            {
                                for (int i = 0; i < mainForm.dataGridView1.Rows.Count; i++)
                                {
                                    if (mainForm.dataGridView1.Rows[i].Cells[2].Value.ToString().Contains(textBox1.Text))
                                        indexAchievements.Add(i);
                                }
                            }
                            if (indexAchievements.Count != 0)
                                mainForm.dataGridView1.Rows[indexAchievements.First()].Selected = true;
                            else
                                MessageBox.Show("Запись не найдена");
                            break;
                        case "Developers":
                            List<int> indexDevelopers = new List<int>();
                            if (textBox1.Text != "")
                            {
                                for (int i = 0; i < mainForm.dataGridView1.Rows.Count; i++)
                                {
                                    if (mainForm.dataGridView1.Rows[i].Cells[1].Value.ToString().Contains(textBox1.Text))
                                        indexDevelopers.Add(i);
                                }
                            }
                            if (indexDevelopers.Count != 0)
                                mainForm.dataGridView1.Rows[indexDevelopers.First()].Selected = true;
                            else
                                MessageBox.Show("Запись не найдена");
                            break;
                        case "Genres":
                            List<int> indexGenres = new List<int>();
                            if (textBox1.Text != "")
                            {
                                for (int i = 0; i < mainForm.dataGridView1.Rows.Count; i++)
                                {
                                    if (mainForm.dataGridView1.Rows[i].Cells[0].Value.ToString().Contains(textBox1.Text))
                                        indexGenres.Add(i);
                                }
                            }
                            if (indexGenres.Count != 0)
                                mainForm.dataGridView1.Rows[indexGenres.First()].Selected = true;
                            else
                                MessageBox.Show("Запись не найдена");
                            break;
                        case "Publishers":
                            List<int> indexPublishers = new List<int>();
                            if (textBox1.Text != "")
                            {
                                for (int i = 0; i < mainForm.dataGridView1.Rows.Count; i++)
                                {
                                    if (mainForm.dataGridView1.Rows[i].Cells[1].Value.ToString().Contains(textBox1.Text))
                                        indexPublishers.Add(i);
                                }
                            }
                            if (indexPublishers.Count != 0)
                                mainForm.dataGridView1.Rows[indexPublishers.First()].Selected = true;
                            else
                                MessageBox.Show("Запись не найдена");
                            break;
                    }
                }
                this.Close();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox1.Text))
                searchBtn.Enabled = false;
            else
                searchBtn.Enabled = true;
        }
    }
}

using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace KursachDB
{
    public partial class ChangeForm : Form
    {
        string nameOfTable;
        int keyEdit;
        public ChangeForm(string nameOfTable, DataRow dataRow)
        {
            InitializeComponent();
            this.nameOfTable = nameOfTable;
            switch (nameOfTable)
            {
                case "Games":
                    keyEdit = int.Parse(dataRow[0].ToString());
                    textBox1.Text = dataRow[1].ToString();
                    textBox2.Text = dataRow[2].ToString();
                    textBox3.Text = dataRow[3].ToString();
                    dateTimePicker1.Value = DateTime.Parse(dataRow[4].ToString());
                    textBox4.Text = dataRow[5].ToString();
                    textBox5.Text = dataRow[6].ToString();
                    break;
                case "Achievements":
                    keyEdit = int.Parse(dataRow[0].ToString());
                    label1.Text = "ID коллекции достижений";
                    label2.Text = "Название достижения";
                    label3.Text = "Дата получения";
                    textBox1.Text = dataRow[1].ToString();
                    textBox2.Text = dataRow[2].ToString();
                    dateTimePicker1.Location = new Point(223,98);
                    dateTimePicker1.Value = DateTime.Parse(dataRow[3].ToString());
                    label4.Visible = false;
                    label5.Visible = false;
                    label7.Visible = false;
                    textBox3.Visible = false;
                    textBox4.Visible = false;
                    textBox5.Visible = false;
                    break;
                case "Developers":
                    keyEdit = int.Parse(dataRow[0].ToString());
                    label1.Text = "Имя разработчика";
                    textBox1.Text = dataRow[1].ToString();
                    dateTimePicker1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label7.Visible = false;
                    textBox2.Visible = false;
                    textBox3.Visible = false;
                    textBox4.Visible = false;
                    textBox5.Visible = false;
                    break;
                case "Publishers":
                    keyEdit = int.Parse(dataRow[0].ToString());
                    label1.Text = "Имя издателя";
                    textBox1.Text = dataRow[1].ToString();
                    dateTimePicker1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label7.Visible = false;
                    textBox2.Visible = false;
                    textBox3.Visible = false;
                    textBox4.Visible = false;
                    textBox5.Visible = false;
                    break;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = this.Owner as MainForm;
            try
            {
                switch (nameOfTable)
                {
                    case "Games":
                        mainForm.tableDataSet.Games.FindByGameID(keyEdit).CollAchievementsID = int.Parse(textBox1.Text);
                        mainForm.tableDataSet.Games.FindByGameID(keyEdit).GameName = textBox2.Text;
                        mainForm.tableDataSet.Games.FindByGameID(keyEdit).Genre = textBox3.Text;
                        mainForm.tableDataSet.Games.FindByGameID(keyEdit).ReleaseYear = dateTimePicker1.Value;
                        mainForm.tableDataSet.Games.FindByGameID(keyEdit).DeveloperID = int.Parse(textBox5.Text);
                        mainForm.tableDataSet.Games.FindByGameID(keyEdit).PublisherID = int.Parse(textBox4.Text);
                        mainForm.gamesAdapter.Update(mainForm.tableDataSet.Games);
                        mainForm.tableDataSet.Games.AcceptChanges();
                        
                        break;
                    case "Achievements":
                        mainForm.tableDataSet.Achievements.FindByAchievementsID(keyEdit).CollAchievementsID = int.Parse(textBox1.Text);
                        mainForm.tableDataSet.Achievements.FindByAchievementsID(keyEdit).NameOfAchievement = textBox2.Text;
                        mainForm.tableDataSet.Achievements.FindByAchievementsID(keyEdit).DateOfGetting = dateTimePicker1.Value;
                        mainForm.achievementsAdapter.Update(mainForm.tableDataSet.Achievements);
                        mainForm.tableDataSet.Achievements.AcceptChanges();
                        break;
                    case "Developers":
                        mainForm.tableDataSet.Developers.FindByDeveloperID(keyEdit).Developer = textBox1.Text;
                        mainForm.developersAdapter.Update(mainForm.tableDataSet.Developers);
                        mainForm.tableDataSet.Developers.AcceptChanges();
                        break;
                    case "Publishers":
                        mainForm.tableDataSet.Publishers.FindByPublisherID(keyEdit).Publisher = textBox1.Text;
                        mainForm.publishersAdapter.Update(mainForm.tableDataSet.Publishers);
                        mainForm.tableDataSet.Publishers.AcceptChanges();
                        break;
                }
                textBox1.Text = textBox2.Text = textBox3.Text = textBox5.Text = textBox4.Text =  "";
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка\nВозможно, данные были введены неверно\nТекст ошибки: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

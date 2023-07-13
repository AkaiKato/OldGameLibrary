
namespace KursachDB
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьИгруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьИгруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьИгруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запросыКБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всеИгрыРазработчикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всеИгрыИздателяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всеИгрыВОпределенномЖанреToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всеИгрыЗаОпределенныйГодToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.достиженияОднойИгрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Publishers = new System.Windows.Forms.Button();
            this.Developers = new System.Windows.Forms.Button();
            this.Genre = new System.Windows.Forms.Button();
            this.Achievements = new System.Windows.Forms.Button();
            this.Games = new System.Windows.Forms.Button();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gameLibraryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameLibraryDataSet = new KursachDB.GameLibraryDataSet();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameLibraryDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameLibraryDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.правкаToolStripMenuItem,
            this.найтиToolStripMenuItem,
            this.запросыКБДToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1138, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьИгруToolStripMenuItem,
            this.изменитьИгруToolStripMenuItem,
            this.удалитьИгруToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // добавитьИгруToolStripMenuItem
            // 
            this.добавитьИгруToolStripMenuItem.Name = "добавитьИгруToolStripMenuItem";
            this.добавитьИгруToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.добавитьИгруToolStripMenuItem.Text = "Добавить";
            this.добавитьИгруToolStripMenuItem.Click += new System.EventHandler(this.добавитьИгруToolStripMenuItem_Click);
            // 
            // изменитьИгруToolStripMenuItem
            // 
            this.изменитьИгруToolStripMenuItem.Name = "изменитьИгруToolStripMenuItem";
            this.изменитьИгруToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.изменитьИгруToolStripMenuItem.Text = "Изменить";
            this.изменитьИгруToolStripMenuItem.Click += new System.EventHandler(this.изменитьИгруToolStripMenuItem_Click);
            // 
            // удалитьИгруToolStripMenuItem
            // 
            this.удалитьИгруToolStripMenuItem.Name = "удалитьИгруToolStripMenuItem";
            this.удалитьИгруToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.удалитьИгруToolStripMenuItem.Text = "Удалить";
            this.удалитьИгруToolStripMenuItem.Click += new System.EventHandler(this.удалитьИгруToolStripMenuItem_Click);
            // 
            // найтиToolStripMenuItem
            // 
            this.найтиToolStripMenuItem.Name = "найтиToolStripMenuItem";
            this.найтиToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.найтиToolStripMenuItem.Text = "Найти";
            this.найтиToolStripMenuItem.Click += new System.EventHandler(this.найтиToolStripMenuItem_Click);
            // 
            // запросыКБДToolStripMenuItem
            // 
            this.запросыКБДToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.всеИгрыРазработчикаToolStripMenuItem,
            this.всеИгрыИздателяToolStripMenuItem,
            this.всеИгрыВОпределенномЖанреToolStripMenuItem,
            this.всеИгрыЗаОпределенныйГодToolStripMenuItem,
            this.достиженияОднойИгрыToolStripMenuItem});
            this.запросыКБДToolStripMenuItem.Name = "запросыКБДToolStripMenuItem";
            this.запросыКБДToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.запросыКБДToolStripMenuItem.Text = "Запросы к БД";
            // 
            // всеИгрыРазработчикаToolStripMenuItem
            // 
            this.всеИгрыРазработчикаToolStripMenuItem.Name = "всеИгрыРазработчикаToolStripMenuItem";
            this.всеИгрыРазработчикаToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.всеИгрыРазработчикаToolStripMenuItem.Text = "Все игры разработчика";
            this.всеИгрыРазработчикаToolStripMenuItem.Click += new System.EventHandler(this.всеИгрыРазработчикаToolStripMenuItem_Click);
            // 
            // всеИгрыИздателяToolStripMenuItem
            // 
            this.всеИгрыИздателяToolStripMenuItem.Name = "всеИгрыИздателяToolStripMenuItem";
            this.всеИгрыИздателяToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.всеИгрыИздателяToolStripMenuItem.Text = "Все игры издателя";
            this.всеИгрыИздателяToolStripMenuItem.Click += new System.EventHandler(this.всеИгрыИздателяToolStripMenuItem_Click);
            // 
            // всеИгрыВОпределенномЖанреToolStripMenuItem
            // 
            this.всеИгрыВОпределенномЖанреToolStripMenuItem.Name = "всеИгрыВОпределенномЖанреToolStripMenuItem";
            this.всеИгрыВОпределенномЖанреToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.всеИгрыВОпределенномЖанреToolStripMenuItem.Text = "Все игры в определенном жанре";
            this.всеИгрыВОпределенномЖанреToolStripMenuItem.Click += new System.EventHandler(this.всеИгрыВОпределенномЖанреToolStripMenuItem_Click);
            // 
            // всеИгрыЗаОпределенныйГодToolStripMenuItem
            // 
            this.всеИгрыЗаОпределенныйГодToolStripMenuItem.Name = "всеИгрыЗаОпределенныйГодToolStripMenuItem";
            this.всеИгрыЗаОпределенныйГодToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.всеИгрыЗаОпределенныйГодToolStripMenuItem.Text = "Все игры за определенный год";
            this.всеИгрыЗаОпределенныйГодToolStripMenuItem.Click += new System.EventHandler(this.всеИгрыЗаОпределенныйГодToolStripMenuItem_Click);
            // 
            // достиженияОднойИгрыToolStripMenuItem
            // 
            this.достиженияОднойИгрыToolStripMenuItem.Name = "достиженияОднойИгрыToolStripMenuItem";
            this.достиженияОднойИгрыToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.достиженияОднойИгрыToolStripMenuItem.Text = "Достижения одной игры";
            this.достиженияОднойИгрыToolStripMenuItem.Click += new System.EventHandler(this.достиженияОднойИгрыToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Publishers);
            this.panel1.Controls.Add(this.Developers);
            this.panel1.Controls.Add(this.Genre);
            this.panel1.Controls.Add(this.Achievements);
            this.panel1.Controls.Add(this.Games);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 307);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F);
            this.label1.Location = new System.Drawing.Point(70, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Game library";
            // 
            // Publishers
            // 
            this.Publishers.Font = new System.Drawing.Font("Georgia", 13F);
            this.Publishers.Location = new System.Drawing.Point(3, 257);
            this.Publishers.Name = "Publishers";
            this.Publishers.Size = new System.Drawing.Size(291, 44);
            this.Publishers.TabIndex = 7;
            this.Publishers.Text = "Издатели";
            this.Publishers.UseVisualStyleBackColor = true;
            this.Publishers.Click += new System.EventHandler(this.Publishers_Click);
            // 
            // Developers
            // 
            this.Developers.Font = new System.Drawing.Font("Georgia", 13F);
            this.Developers.Location = new System.Drawing.Point(3, 207);
            this.Developers.Name = "Developers";
            this.Developers.Size = new System.Drawing.Size(291, 44);
            this.Developers.TabIndex = 6;
            this.Developers.Text = "Разработчики";
            this.Developers.UseVisualStyleBackColor = true;
            this.Developers.Click += new System.EventHandler(this.Developers_Click);
            // 
            // Genre
            // 
            this.Genre.Font = new System.Drawing.Font("Georgia", 13F);
            this.Genre.Location = new System.Drawing.Point(3, 157);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(291, 44);
            this.Genre.TabIndex = 5;
            this.Genre.Text = "Жанры";
            this.Genre.UseVisualStyleBackColor = true;
            this.Genre.Click += new System.EventHandler(this.Genre_Click);
            // 
            // Achievements
            // 
            this.Achievements.Font = new System.Drawing.Font("Georgia", 13F);
            this.Achievements.Location = new System.Drawing.Point(3, 107);
            this.Achievements.Name = "Achievements";
            this.Achievements.Size = new System.Drawing.Size(291, 44);
            this.Achievements.TabIndex = 4;
            this.Achievements.Text = "Достижения";
            this.Achievements.UseVisualStyleBackColor = true;
            this.Achievements.Click += new System.EventHandler(this.Achievements_Click);
            // 
            // Games
            // 
            this.Games.Font = new System.Drawing.Font("Georgia", 13F);
            this.Games.Location = new System.Drawing.Point(3, 57);
            this.Games.Name = "Games";
            this.Games.Size = new System.Drawing.Size(291, 44);
            this.Games.TabIndex = 3;
            this.Games.Text = "Игры";
            this.Games.UseVisualStyleBackColor = true;
            this.Games.Click += new System.EventHandler(this.Games_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(191, 340);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(115, 23);
            this.LoginBtn.TabIndex = 3;
            this.LoginBtn.Text = "Авторизация";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(315, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(811, 542);
            this.dataGridView1.TabIndex = 2;
            // 
            // gameLibraryDataSetBindingSource
            // 
            this.gameLibraryDataSetBindingSource.DataSource = this.gameLibraryDataSet;
            this.gameLibraryDataSetBindingSource.Position = 0;
            // 
            // gameLibraryDataSet
            // 
            this.gameLibraryDataSet.DataSetName = "GameLibraryDataSet";
            this.gameLibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 581);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "GameLibrary";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameLibraryDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameLibraryDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьИгруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьИгруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьИгруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запросыКБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Publishers;
        private System.Windows.Forms.Button Developers;
        private System.Windows.Forms.Button Genre;
        private System.Windows.Forms.Button Achievements;
        private System.Windows.Forms.Button Games;
        private System.Windows.Forms.BindingSource gameLibraryDataSetBindingSource;
        private GameLibraryDataSet gameLibraryDataSet;
        private System.Windows.Forms.Button LoginBtn;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem всеИгрыРазработчикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всеИгрыИздателяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всеИгрыВОпределенномЖанреToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всеИгрыЗаОпределенныйГодToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem достиженияОднойИгрыToolStripMenuItem;
    }
}


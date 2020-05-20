namespace WindowsFormsApp7
{
    partial class Form1
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.Sort = new System.Windows.Forms.ToolStripMenuItem();
            this.BiSort = new System.Windows.Forms.ToolStripMenuItem();
            this.ProstSort = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColvoMass = new System.Windows.Forms.ToolStripMenuItem();
            this.Randoom = new System.Windows.Forms.ToolStripMenuItem();
            this.chi1 = new System.Windows.Forms.TextBox();
            this.chi2 = new System.Windows.Forms.TextBox();
            this.sravnenie = new System.Windows.Forms.Label();
            this.massiv = new System.Windows.Forms.DataGridView();
            this.vvod = new System.Windows.Forms.TextBox();
            this.butVvod = new System.Windows.Forms.Button();
            this.labVvod = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.massiv)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Sort,
            this.runToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(635, 28);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // Sort
            // 
            this.Sort.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BiSort,
            this.ProstSort});
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(104, 24);
            this.Sort.Text = "Сортировка";
            // 
            // BiSort
            // 
            this.BiSort.Name = "BiSort";
            this.BiSort.Size = new System.Drawing.Size(238, 26);
            this.BiSort.Text = "Бинарная сортировка";
            this.BiSort.Click += new System.EventHandler(this.BiSort_Click);
            // 
            // ProstSort
            // 
            this.ProstSort.Name = "ProstSort";
            this.ProstSort.Size = new System.Drawing.Size(238, 26);
            this.ProstSort.Text = "Простыми вставками";
            this.ProstSort.Click += new System.EventHandler(this.ProstSort_Click);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ColvoMass,
            this.Randoom});
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.runToolStripMenuItem.Text = "Массив";
            // 
            // ColvoMass
            // 
            this.ColvoMass.Name = "ColvoMass";
            this.ColvoMass.Size = new System.Drawing.Size(320, 26);
            this.ColvoMass.Text = "Ввести размер массива";
            this.ColvoMass.Click += new System.EventHandler(this.ColvoMass_Click);
            // 
            // Randoom
            // 
            this.Randoom.Name = "Randoom";
            this.Randoom.Size = new System.Drawing.Size(320, 26);
            this.Randoom.Text = "Заполнить рандомными числами";
            this.Randoom.Click += new System.EventHandler(this.Randoom_Click);
            // 
            // chi1
            // 
            this.chi1.Enabled = false;
            this.chi1.Location = new System.Drawing.Point(151, 81);
            this.chi1.Name = "chi1";
            this.chi1.Size = new System.Drawing.Size(100, 22);
            this.chi1.TabIndex = 1;
            // 
            // chi2
            // 
            this.chi2.Enabled = false;
            this.chi2.Location = new System.Drawing.Point(351, 84);
            this.chi2.Name = "chi2";
            this.chi2.Size = new System.Drawing.Size(100, 22);
            this.chi2.TabIndex = 2;
            // 
            // sravnenie
            // 
            this.sravnenie.AutoSize = true;
            this.sravnenie.Location = new System.Drawing.Point(257, 84);
            this.sravnenie.Name = "sravnenie";
            this.sravnenie.Size = new System.Drawing.Size(88, 17);
            this.sravnenie.TabIndex = 3;
            this.sravnenie.Text = "Сравниваем";
            // 
            // massiv
            // 
            this.massiv.AllowUserToAddRows = false;
            this.massiv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.massiv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.massiv.ColumnHeadersVisible = false;
            this.massiv.EnableHeadersVisualStyles = false;
            this.massiv.Location = new System.Drawing.Point(12, 31);
            this.massiv.Name = "massiv";
            this.massiv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.massiv.RowHeadersVisible = false;
            this.massiv.RowTemplate.Height = 24;
            this.massiv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.massiv.ShowEditingIcon = false;
            this.massiv.Size = new System.Drawing.Size(605, 36);
            this.massiv.TabIndex = 4;
            // 
            // vvod
            // 
            this.vvod.Location = new System.Drawing.Point(162, 137);
            this.vvod.Name = "vvod";
            this.vvod.Size = new System.Drawing.Size(100, 22);
            this.vvod.TabIndex = 5;
            this.vvod.Visible = false;
            // 
            // butVvod
            // 
            this.butVvod.Location = new System.Drawing.Point(277, 122);
            this.butVvod.Name = "butVvod";
            this.butVvod.Size = new System.Drawing.Size(58, 37);
            this.butVvod.TabIndex = 6;
            this.butVvod.Text = "—>";
            this.butVvod.UseVisualStyleBackColor = true;
            this.butVvod.Visible = false;
            this.butVvod.Click += new System.EventHandler(this.butVvod_Click);
            // 
            // labVvod
            // 
            this.labVvod.AutoSize = true;
            this.labVvod.Location = new System.Drawing.Point(9, 125);
            this.labVvod.Name = "labVvod";
            this.labVvod.Size = new System.Drawing.Size(147, 34);
            this.labVvod.TabIndex = 7;
            this.labVvod.Text = "Введите количество \r\nэлементов в массиве";
            this.labVvod.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(635, 188);
            this.Controls.Add(this.labVvod);
            this.Controls.Add(this.butVvod);
            this.Controls.Add(this.vvod);
            this.Controls.Add(this.massiv);
            this.Controls.Add(this.sravnenie);
            this.Controls.Add(this.chi2);
            this.Controls.Add(this.chi1);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Sort";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.massiv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem Sort;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BiSort;
        private System.Windows.Forms.ToolStripMenuItem ProstSort;
        private System.Windows.Forms.TextBox chi1;
        private System.Windows.Forms.TextBox chi2;
        private System.Windows.Forms.Label sravnenie;
        private System.Windows.Forms.DataGridView massiv;
        private System.Windows.Forms.TextBox vvod;
        private System.Windows.Forms.Button butVvod;
        private System.Windows.Forms.Label labVvod;
        private System.Windows.Forms.ToolStripMenuItem ColvoMass;
        private System.Windows.Forms.ToolStripMenuItem Randoom;
    }
}


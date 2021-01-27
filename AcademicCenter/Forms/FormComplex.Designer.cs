
namespace AcademicCenter
{
    partial class FormComplex
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.комплексToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.материалыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тестыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pListTest = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listTest = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pListTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(821, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // комплексToolStripMenuItem
            // 
            this.комплексToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settings,
            this.toolStripMenuItem1,
            this.exit});
            this.комплексToolStripMenuItem.Name = "комплексToolStripMenuItem";
            this.комплексToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.комплексToolStripMenuItem.Text = "Комплекс";
            // 
            // settings
            // 
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(134, 22);
            this.settings.Text = "Настройки";
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(131, 6);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(134, 22);
            this.exit.Text = "Выход";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // материалыToolStripMenuItem
            // 
            this.материалыToolStripMenuItem.Name = "материалыToolStripMenuItem";
            this.материалыToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.материалыToolStripMenuItem.Text = "Материалы";
            // 
            // тестыToolStripMenuItem
            // 
            this.тестыToolStripMenuItem.Name = "тестыToolStripMenuItem";
            this.тестыToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.тестыToolStripMenuItem.Text = "Тесты";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // pListTest
            // 
            this.pListTest.BackColor = System.Drawing.Color.White;
            this.pListTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pListTest.Controls.Add(this.listTest);
            this.pListTest.Controls.Add(this.button1);
            this.pListTest.Controls.Add(this.label1);
            this.pListTest.Location = new System.Drawing.Point(198, 98);
            this.pListTest.Name = "pListTest";
            this.pListTest.Size = new System.Drawing.Size(425, 272);
            this.pListTest.TabIndex = 1;
            this.pListTest.Visible = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "ДОСТУПНЫЕ ТЕСТЫ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listTest
            // 
            this.listTest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listTest.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listTest.FormattingEnabled = true;
            this.listTest.IntegralHeight = false;
            this.listTest.ItemHeight = 34;
            this.listTest.Location = new System.Drawing.Point(0, 26);
            this.listTest.Name = "listTest";
            this.listTest.Size = new System.Drawing.Size(423, 202);
            this.listTest.TabIndex = 1;
            this.listTest.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listTest_DrawItem);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.button1.Location = new System.Drawing.Point(0, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(423, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Приступить к выполнению теста";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FormComplex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 480);
            this.Controls.Add(this.pListTest);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormComplex";
            this.Text = "Обучающе-тестирующий комплекс по учебной дисциплине ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pListTest.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem комплексToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem материалыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тестыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settings;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.Panel pListTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listTest;
        private System.Windows.Forms.Button button1;
    }
}


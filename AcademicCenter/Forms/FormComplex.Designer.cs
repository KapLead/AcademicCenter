
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormComplex));
            this.комплексToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.материалыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тестыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pListTest = new System.Windows.Forms.Panel();
            this.listTest = new System.Windows.Forms.ListBox();
            this.startTest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.комплексToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.тестыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolDocs = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolExit = new System.Windows.Forms.ToolStripMenuItem();
            this.panelDocs = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.listTest2 = new System.Windows.Forms.ListBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panelDoc = new System.Windows.Forms.Panel();
            this.pListTest.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelDocs.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
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
            this.pListTest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pListTest.BackColor = System.Drawing.Color.White;
            this.pListTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pListTest.Controls.Add(this.listTest);
            this.pListTest.Controls.Add(this.startTest);
            this.pListTest.Controls.Add(this.label1);
            this.pListTest.Location = new System.Drawing.Point(206, 100);
            this.pListTest.Name = "pListTest";
            this.pListTest.Size = new System.Drawing.Size(424, 272);
            this.pListTest.TabIndex = 1;
            this.pListTest.Visible = false;
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
            this.listTest.Size = new System.Drawing.Size(422, 202);
            this.listTest.TabIndex = 1;
            this.listTest.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listTest_DrawItem);
            // 
            // startTest
            // 
            this.startTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.startTest.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.startTest.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.startTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startTest.ForeColor = System.Drawing.SystemColors.GrayText;
            this.startTest.Location = new System.Drawing.Point(0, 228);
            this.startTest.Name = "startTest";
            this.startTest.Size = new System.Drawing.Size(422, 42);
            this.startTest.TabIndex = 2;
            this.startTest.Text = "Приступить к выполнению теста";
            this.startTest.UseVisualStyleBackColor = false;
            this.startTest.Click += new System.EventHandler(this.startTest_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "ТЕСТЫ ПО ДИСЦИПЛИНЕ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(0, 24);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10);
            this.label2.Size = new System.Drawing.Size(821, 456);
            this.label2.TabIndex = 2;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.комплексToolStripMenuItem1,
            this.тестыToolStripMenuItem1,
            this.toolDocs,
            this.помощьToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(821, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // комплексToolStripMenuItem1
            // 
            this.комплексToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolExit});
            this.комплексToolStripMenuItem1.Name = "комплексToolStripMenuItem1";
            this.комплексToolStripMenuItem1.Size = new System.Drawing.Size(74, 20);
            this.комплексToolStripMenuItem1.Text = "Комплекс";
            // 
            // тестыToolStripMenuItem1
            // 
            this.тестыToolStripMenuItem1.Name = "тестыToolStripMenuItem1";
            this.тестыToolStripMenuItem1.Size = new System.Drawing.Size(51, 20);
            this.тестыToolStripMenuItem1.Text = "Тесты";
            this.тестыToolStripMenuItem1.Click += new System.EventHandler(this.тестыToolStripMenuItem1_Click);
            // 
            // toolDocs
            // 
            this.toolDocs.Name = "toolDocs";
            this.toolDocs.Size = new System.Drawing.Size(83, 20);
            this.toolDocs.Text = "Материалы";
            this.toolDocs.Click += new System.EventHandler(this.toolDocs_Click);
            // 
            // помощьToolStripMenuItem1
            // 
            this.помощьToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.помощьToolStripMenuItem1.Name = "помощьToolStripMenuItem1";
            this.помощьToolStripMenuItem1.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem1.Text = "Помощь";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.оПрограммеToolStripMenuItem.Text = "О Программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // toolExit
            // 
            this.toolExit.Name = "toolExit";
            this.toolExit.Size = new System.Drawing.Size(180, 22);
            this.toolExit.Text = "Выход";
            this.toolExit.Click += new System.EventHandler(this.toolExit_Click);
            // 
            // panelDocs
            // 
            this.panelDocs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelDocs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDocs.Controls.Add(this.panel2);
            this.panelDocs.Controls.Add(this.panel7);
            this.panelDocs.Controls.Add(this.panel4);
            this.panelDocs.Controls.Add(this.panel3);
            this.panelDocs.Controls.Add(this.panel6);
            this.panelDocs.Location = new System.Drawing.Point(100, 94);
            this.panelDocs.Name = "panelDocs";
            this.panelDocs.Size = new System.Drawing.Size(622, 296);
            this.panelDocs.TabIndex = 4;
            this.panelDocs.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listTest2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 291);
            this.panel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(383, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "ТЕСТЫ ПО ДИСЦИПЛИНЕ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 291);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(617, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 291);
            this.panel4.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "ДОКУМЕНТЫ М МАТЕРИАЛЫ ПО ТЕСТУ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 291);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(620, 3);
            this.panel6.TabIndex = 5;
            // 
            // listTest2
            // 
            this.listTest2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listTest2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listTest2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listTest2.FormattingEnabled = true;
            this.listTest2.IntegralHeight = false;
            this.listTest2.ItemHeight = 34;
            this.listTest2.Location = new System.Drawing.Point(0, 26);
            this.listTest2.Name = "listTest2";
            this.listTest2.Size = new System.Drawing.Size(383, 265);
            this.listTest2.TabIndex = 2;
            this.listTest2.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listTest_DrawItem);
            this.listTest2.SelectedIndexChanged += new System.EventHandler(this.listTest2_SelectedIndexChanged);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel7.Controls.Add(this.panelDoc);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(386, 0);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.panel7.Size = new System.Drawing.Size(231, 291);
            this.panel7.TabIndex = 7;
            // 
            // panelDoc
            // 
            this.panelDoc.AutoScroll = true;
            this.panelDoc.BackColor = System.Drawing.SystemColors.Window;
            this.panelDoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDoc.Location = new System.Drawing.Point(1, 26);
            this.panelDoc.Name = "panelDoc";
            this.panelDoc.Size = new System.Drawing.Size(230, 265);
            this.panelDoc.TabIndex = 5;
            // 
            // FormComplex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 480);
            this.Controls.Add(this.panelDocs);
            this.Controls.Add(this.pListTest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormComplex";
            this.Text = "Обучающе-тестирующий комплекс по учебной дисциплине ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pListTest.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelDocs.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Button startTest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem комплексToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolExit;
        private System.Windows.Forms.ToolStripMenuItem тестыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolDocs;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Panel panelDocs;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ListBox listTest2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panelDoc;
    }
}


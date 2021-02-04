
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
            this.комплексToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.редакторТестовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тестыToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.документыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.комплексToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolExit = new System.Windows.Forms.ToolStripMenuItem();
            this.тестыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolDocs = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelDocs = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panelDoc = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.docAll = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.docLabs = new System.Windows.Forms.Button();
            this.docKurs = new System.Windows.Forms.Button();
            this.docBooks = new System.Windows.Forms.Button();
            this.docVideos = new System.Windows.Forms.Button();
            this.docOthers = new System.Windows.Forms.Button();
            this.addDoc = new System.Windows.Forms.Button();
            this.pListTest.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelDocs.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.комплексToolStripMenuItem2,
            this.тестыToolStripMenuItem2,
            this.документыToolStripMenuItem,
            this.помощьToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(821, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // комплексToolStripMenuItem2
            // 
            this.комплексToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редакторТестовToolStripMenuItem,
            this.toolStripMenuItem2,
            this.выходToolStripMenuItem});
            this.комплексToolStripMenuItem2.Name = "комплексToolStripMenuItem2";
            this.комплексToolStripMenuItem2.Size = new System.Drawing.Size(74, 20);
            this.комплексToolStripMenuItem2.Text = "Комплекс";
            // 
            // редакторТестовToolStripMenuItem
            // 
            this.редакторТестовToolStripMenuItem.Name = "редакторТестовToolStripMenuItem";
            this.редакторТестовToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.редакторТестовToolStripMenuItem.Text = "Редактор тестов";
            this.редакторТестовToolStripMenuItem.Click += new System.EventHandler(this.редакторТестовToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(159, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.exit_Click);
            // 
            // тестыToolStripMenuItem2
            // 
            this.тестыToolStripMenuItem2.Name = "тестыToolStripMenuItem2";
            this.тестыToolStripMenuItem2.Size = new System.Drawing.Size(51, 20);
            this.тестыToolStripMenuItem2.Text = "Тесты";
            this.тестыToolStripMenuItem2.Click += new System.EventHandler(this.тестыToolStripMenuItem1_Click);
            // 
            // документыToolStripMenuItem
            // 
            this.документыToolStripMenuItem.Name = "документыToolStripMenuItem";
            this.документыToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.документыToolStripMenuItem.Text = "Документы";
            this.документыToolStripMenuItem.Click += new System.EventHandler(this.toolDocs_Click);
            // 
            // помощьToolStripMenuItem2
            // 
            this.помощьToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem1});
            this.помощьToolStripMenuItem2.Name = "помощьToolStripMenuItem2";
            this.помощьToolStripMenuItem2.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem2.Text = "Помощь";
            // 
            // оПрограммеToolStripMenuItem1
            // 
            this.оПрограммеToolStripMenuItem1.Name = "оПрограммеToolStripMenuItem1";
            this.оПрограммеToolStripMenuItem1.Size = new System.Drawing.Size(151, 22);
            this.оПрограммеToolStripMenuItem1.Text = "О Программе";
            this.оПрограммеToolStripMenuItem1.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // комплексToolStripMenuItem1
            // 
            this.комплексToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolExit});
            this.комплексToolStripMenuItem1.Name = "комплексToolStripMenuItem1";
            this.комплексToolStripMenuItem1.Size = new System.Drawing.Size(74, 20);
            this.комплексToolStripMenuItem1.Text = "Комплекс";
            // 
            // toolExit
            // 
            this.toolExit.Name = "toolExit";
            this.toolExit.Size = new System.Drawing.Size(109, 22);
            this.toolExit.Text = "Выход";
            this.toolExit.Click += new System.EventHandler(this.toolExit_Click);
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
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.оПрограммеToolStripMenuItem.Text = "О Программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // panelDocs
            // 
            this.panelDocs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelDocs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDocs.Controls.Add(this.panel7);
            this.panelDocs.Controls.Add(this.panel4);
            this.panelDocs.Controls.Add(this.panel6);
            this.panelDocs.Location = new System.Drawing.Point(161, 45);
            this.panelDocs.Name = "panelDocs";
            this.panelDocs.Size = new System.Drawing.Size(469, 409);
            this.panelDocs.TabIndex = 4;
            this.panelDocs.Visible = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel7.Controls.Add(this.addDoc);
            this.panel7.Controls.Add(this.panelDoc);
            this.panel7.Controls.Add(this.panel1);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.panel7.Size = new System.Drawing.Size(464, 404);
            this.panel7.TabIndex = 7;
            // 
            // panelDoc
            // 
            this.panelDoc.AutoScroll = true;
            this.panelDoc.BackColor = System.Drawing.SystemColors.Window;
            this.panelDoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDoc.Location = new System.Drawing.Point(1, 26);
            this.panelDoc.Name = "panelDoc";
            this.panelDoc.Size = new System.Drawing.Size(463, 339);
            this.panelDoc.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(463, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "ДОКУМЕНТЫ ПО ДИСЦИПЛИНЕ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(464, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 404);
            this.panel4.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 404);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(467, 3);
            this.panel6.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.docOthers);
            this.panel1.Controls.Add(this.docVideos);
            this.panel1.Controls.Add(this.docBooks);
            this.panel1.Controls.Add(this.docKurs);
            this.panel1.Controls.Add(this.docLabs);
            this.panel1.Controls.Add(this.docAll);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(1, 365);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 39);
            this.panel1.TabIndex = 0;
            // 
            // docAll
            // 
            this.docAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.docAll.BackColor = System.Drawing.Color.White;
            this.docAll.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.docAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.docAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.docAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.docAll.Location = new System.Drawing.Point(7, -1);
            this.docAll.Name = "docAll";
            this.docAll.Size = new System.Drawing.Size(36, 34);
            this.docAll.TabIndex = 0;
            this.docAll.Tag = "0";
            this.docAll.Text = "Все";
            this.docAll.UseVisualStyleBackColor = false;
            this.docAll.Click += new System.EventHandler(this.docOthers_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(463, 1);
            this.panel2.TabIndex = 1;
            // 
            // docLabs
            // 
            this.docLabs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.docLabs.BackColor = System.Drawing.Color.White;
            this.docLabs.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.docLabs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.docLabs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.docLabs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.docLabs.Location = new System.Drawing.Point(42, 0);
            this.docLabs.Name = "docLabs";
            this.docLabs.Size = new System.Drawing.Size(95, 34);
            this.docLabs.TabIndex = 2;
            this.docLabs.Tag = "1";
            this.docLabs.Text = "Лаболаторные";
            this.docLabs.UseVisualStyleBackColor = false;
            this.docLabs.Click += new System.EventHandler(this.docOthers_Click);
            // 
            // docKurs
            // 
            this.docKurs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.docKurs.BackColor = System.Drawing.Color.White;
            this.docKurs.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.docKurs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.docKurs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.docKurs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.docKurs.Location = new System.Drawing.Point(136, 0);
            this.docKurs.Name = "docKurs";
            this.docKurs.Size = new System.Drawing.Size(74, 34);
            this.docKurs.TabIndex = 3;
            this.docKurs.Tag = "2";
            this.docKurs.Text = "Курсовые";
            this.docKurs.UseVisualStyleBackColor = false;
            this.docKurs.Click += new System.EventHandler(this.docOthers_Click);
            // 
            // docBooks
            // 
            this.docBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.docBooks.BackColor = System.Drawing.Color.White;
            this.docBooks.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.docBooks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.docBooks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.docBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.docBooks.Location = new System.Drawing.Point(209, 0);
            this.docBooks.Name = "docBooks";
            this.docBooks.Size = new System.Drawing.Size(54, 34);
            this.docBooks.TabIndex = 4;
            this.docBooks.Tag = "3";
            this.docBooks.Text = "Книги";
            this.docBooks.UseVisualStyleBackColor = false;
            this.docBooks.Click += new System.EventHandler(this.docOthers_Click);
            // 
            // docVideos
            // 
            this.docVideos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.docVideos.BackColor = System.Drawing.Color.White;
            this.docVideos.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.docVideos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.docVideos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.docVideos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.docVideos.Location = new System.Drawing.Point(262, 0);
            this.docVideos.Name = "docVideos";
            this.docVideos.Size = new System.Drawing.Size(54, 34);
            this.docVideos.TabIndex = 5;
            this.docVideos.Tag = "4";
            this.docVideos.Text = "Видео";
            this.docVideos.UseVisualStyleBackColor = false;
            this.docVideos.Click += new System.EventHandler(this.docOthers_Click);
            // 
            // docOthers
            // 
            this.docOthers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.docOthers.BackColor = System.Drawing.Color.White;
            this.docOthers.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.docOthers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.docOthers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.docOthers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.docOthers.Location = new System.Drawing.Point(315, 0);
            this.docOthers.Name = "docOthers";
            this.docOthers.Size = new System.Drawing.Size(54, 34);
            this.docOthers.TabIndex = 6;
            this.docOthers.Tag = "5";
            this.docOthers.Text = "Прочее";
            this.docOthers.UseVisualStyleBackColor = false;
            this.docOthers.Click += new System.EventHandler(this.docOthers_Click);
            // 
            // addDoc
            // 
            this.addDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addDoc.BackColor = System.Drawing.Color.White;
            this.addDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDoc.Location = new System.Drawing.Point(429, 367);
            this.addDoc.Name = "addDoc";
            this.addDoc.Size = new System.Drawing.Size(35, 35);
            this.addDoc.TabIndex = 7;
            this.addDoc.Text = "+";
            this.addDoc.UseVisualStyleBackColor = false;
            // 
            // FormComplex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 480);
            this.Controls.Add(this.panelDocs);
            this.Controls.Add(this.pListTest);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormComplex";
            this.Text = "Обучающе-тестирующий комплекс по учебной дисциплине : ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pListTest.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelDocs.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panelDoc;
        private System.Windows.Forms.ToolStripMenuItem комплексToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тестыToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem документыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem редакторТестовToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button docAll;
        private System.Windows.Forms.Button addDoc;
        private System.Windows.Forms.Button docOthers;
        private System.Windows.Forms.Button docVideos;
        private System.Windows.Forms.Button docBooks;
        private System.Windows.Forms.Button docKurs;
        private System.Windows.Forms.Button docLabs;
        private System.Windows.Forms.Panel panel2;
    }
}


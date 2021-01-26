
namespace AcademicCenter
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Exp_discourse = new System.Windows.Forms.CheckedListBox();
            this.Exp_presentations = new System.Windows.Forms.CheckedListBox();
            this.Exp_laboratory = new System.Windows.Forms.CheckedListBox();
            this.Exp_books = new System.Windows.Forms.CheckedListBox();
            this.Exp_videos = new System.Windows.Forms.CheckedListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(147, 24);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 491);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage1.Size = new System.Drawing.Size(792, 459);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Виды и типы документов";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Exp_discourse);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 217);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Лекции";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(780, 447);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Exp_presentations);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(262, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 217);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Презентации";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Exp_laboratory);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(521, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 217);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Лабораторные работы";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Exp_books);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 226);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(253, 218);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Книги";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Exp_videos);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(262, 226);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(253, 218);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Видеоматериалы";
            // 
            // Exp_discourse
            // 
            this.Exp_discourse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Exp_discourse.CheckOnClick = true;
            this.Exp_discourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Exp_discourse.FormattingEnabled = true;
            this.Exp_discourse.IntegralHeight = false;
            this.Exp_discourse.Location = new System.Drawing.Point(3, 16);
            this.Exp_discourse.MultiColumn = true;
            this.Exp_discourse.Name = "Exp_discourse";
            this.Exp_discourse.Size = new System.Drawing.Size(247, 198);
            this.Exp_discourse.TabIndex = 0;
            this.Exp_discourse.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedChange);
            this.Exp_discourse.Leave += new System.EventHandler(this.Exp_discourse_Leave);
            // 
            // Exp_presentations
            // 
            this.Exp_presentations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Exp_presentations.CheckOnClick = true;
            this.Exp_presentations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Exp_presentations.FormattingEnabled = true;
            this.Exp_presentations.IntegralHeight = false;
            this.Exp_presentations.Location = new System.Drawing.Point(3, 16);
            this.Exp_presentations.MultiColumn = true;
            this.Exp_presentations.Name = "Exp_presentations";
            this.Exp_presentations.Size = new System.Drawing.Size(247, 198);
            this.Exp_presentations.TabIndex = 1;
            this.Exp_presentations.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedChange);
            this.Exp_presentations.Leave += new System.EventHandler(this.Exp_discourse_Leave);
            // 
            // Exp_laboratory
            // 
            this.Exp_laboratory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Exp_laboratory.CheckOnClick = true;
            this.Exp_laboratory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Exp_laboratory.FormattingEnabled = true;
            this.Exp_laboratory.IntegralHeight = false;
            this.Exp_laboratory.Location = new System.Drawing.Point(3, 16);
            this.Exp_laboratory.MultiColumn = true;
            this.Exp_laboratory.Name = "Exp_laboratory";
            this.Exp_laboratory.Size = new System.Drawing.Size(250, 198);
            this.Exp_laboratory.TabIndex = 1;
            this.Exp_laboratory.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedChange);
            this.Exp_laboratory.Leave += new System.EventHandler(this.Exp_discourse_Leave);
            // 
            // Exp_books
            // 
            this.Exp_books.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Exp_books.CheckOnClick = true;
            this.Exp_books.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Exp_books.FormattingEnabled = true;
            this.Exp_books.IntegralHeight = false;
            this.Exp_books.Location = new System.Drawing.Point(3, 16);
            this.Exp_books.MultiColumn = true;
            this.Exp_books.Name = "Exp_books";
            this.Exp_books.Size = new System.Drawing.Size(247, 199);
            this.Exp_books.TabIndex = 1;
            this.Exp_books.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedChange);
            this.Exp_books.Leave += new System.EventHandler(this.Exp_discourse_Leave);
            // 
            // Exp_videos
            // 
            this.Exp_videos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Exp_videos.CheckOnClick = true;
            this.Exp_videos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Exp_videos.FormattingEnabled = true;
            this.Exp_videos.IntegralHeight = false;
            this.Exp_videos.Location = new System.Drawing.Point(3, 16);
            this.Exp_videos.MultiColumn = true;
            this.Exp_videos.Name = "Exp_videos";
            this.Exp_videos.Size = new System.Drawing.Size(247, 199);
            this.Exp_videos.TabIndex = 1;
            this.Exp_videos.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedChange);
            this.Exp_videos.Leave += new System.EventHandler(this.Exp_discourse_Leave);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки ";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox Exp_discourse;
        private System.Windows.Forms.CheckedListBox Exp_books;
        private System.Windows.Forms.CheckedListBox Exp_videos;
        private System.Windows.Forms.CheckedListBox Exp_laboratory;
        private System.Windows.Forms.CheckedListBox Exp_presentations;
    }
}
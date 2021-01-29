
namespace AcademicCenter
{
    partial class FormStudent
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
            this.label1 = new System.Windows.Forms.Label();
            this.fam = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.otch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.group = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // fam
            // 
            this.fam.Location = new System.Drawing.Point(102, 18);
            this.fam.Name = "fam";
            this.fam.Size = new System.Drawing.Size(204, 20);
            this.fam.TabIndex = 1;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(102, 44);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(204, 20);
            this.name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Имя";
            // 
            // otch
            // 
            this.otch.Location = new System.Drawing.Point(102, 70);
            this.otch.Name = "otch";
            this.otch.Size = new System.Drawing.Size(204, 20);
            this.otch.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Отчество";
            // 
            // group
            // 
            this.group.Location = new System.Drawing.Point(102, 96);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(204, 20);
            this.group.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Группа (класс)";
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(21, 146);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(285, 35);
            this.ok.TabIndex = 8;
            this.ok.Text = "Вход";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 193);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.group);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.otch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fam);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStudent";
            this.ShowIcon = false;
            this.Text = "Идентификация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fam;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox otch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox group;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ok;
    }
}
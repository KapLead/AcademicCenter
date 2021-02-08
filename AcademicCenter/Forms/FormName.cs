using System;
using System.Windows.Forms;

namespace AcademicCenter
{
    public partial class FormName : Form
    {
        public static string Value { get; private set; }
        public FormName()
        {
            InitializeComponent();
            Value = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Value = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="" && MessageBox.Show(@"Пустое наименование приведет к отмене добавления документа! Продолжить?", 
                   @"Внимание", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)!= DialogResult.OK)
                return;
            Close();
        }
    }
}

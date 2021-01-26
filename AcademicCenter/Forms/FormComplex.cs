using AcademicCenter.Properties;
using System;
using System.Windows.Forms;

namespace AcademicCenter
{
    public partial class FormComplex : Form
    {
        public FormComplex()
        {
            InitializeComponent();
            this.Text += Settings.Default.Discipline;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e) => Close();
        private void settings_Click(object sender, EventArgs e) => new FormSettings().ShowDialog();
    }
}

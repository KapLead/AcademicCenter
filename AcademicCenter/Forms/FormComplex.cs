using AcademicCenter.Properties;
using System;
using System.IO;
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

        private void Form1_Load(object sender, EventArgs e) => Menu();
        private void exit_Click(object sender, EventArgs e) => Close();
        private void settings_Click(object sender, EventArgs e) => new FormSettings().ShowDialog();

        private void Menu()
        {
            var disc = GetDisciplines();
            if(disc.Length==0)
            {
                if (MessageBox.Show("Нет доступных дисциплин и тестов к ним, создать по умолчанию?", "Внимание...", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
                ;
            }
        }

        /// <summary> Все дисциплины </summary>
        private string[] GetDisciplines()
        {
            Directory.CreateDirectory(JsonSettings.FolderPath + "\\discipline\\");
            return Directory.GetDirectories(JsonSettings.FolderPath + "\\discipline\\", "*", SearchOption.TopDirectoryOnly);
        }
    }
}

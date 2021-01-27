using AcademicCenter.Properties;
using System.Windows.Forms;
using System;
using System.Drawing;

namespace AcademicCenter
{
    public partial class FormComplex : Form
    {
        public FormComplex()
        {
            InitializeComponent();
            this.Text +="\""+Settings.Default.Discipline+ "\"";
        }

        private void Form1_Load(object sender, EventArgs e) => Menu();
        private void exit_Click(object sender, EventArgs e) => Close();
        private void settings_Click(object sender, EventArgs e) => new FormSettings().ShowDialog();

        private void Menu()
        {
            if(Configuration.Disciplines.Count==0)
            {
                //if (MessageBox.Show(
                //        @"Нет доступных дисциплин и тестов к ним, создать по умолчанию?",
                //        @"Внимание...",
                //        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) 
                Configuration.Disciplines = Configuration.GetDisciplines();
                if (Configuration.Disciplines.Count == 0)
                    return;
            }
            listTest.Items.Clear();
            listTest.Items.AddRange(Configuration.Disciplines[0].Tests.ToArray());
            pListTest.Visible = true;
        }

        private void listTest_DrawItem(object sender, DrawItemEventArgs e)
        {
            if(e.Index<0) return;
            Test t = (Test) listTest.Items[e.Index];
            if(t==null) return;
            e.DrawBackground();
            e.Graphics.DrawString(Configuration.Disciplines[0].Title??"..", 
                new Font(listTest.Font.FontFamily,13f, FontStyle.Bold), 
                Brushes.Black, new Point(e.Bounds.X+10,e.Bounds.Y-2) );
            e.Graphics.DrawString(Configuration.Disciplines[0].Descrition??"?", 
                new Font(listTest.Font.FontFamily, 11f, FontStyle.Regular), Brushes.DimGray,
                new RectangleF(e.Bounds.X+10,e.Bounds.Y+14, e.Bounds.Width-14, e.Bounds.Height), 
                new StringFormat{LineAlignment = StringAlignment.Near, Alignment = StringAlignment.Near} );
        }

    }
}

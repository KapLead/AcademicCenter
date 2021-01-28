using AcademicCenter.Properties;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

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
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics,
                    e.Font,
                    e.Bounds,
                    e.Index,
                    e.State ^ DrawItemState.Selected,
                    e.ForeColor,
                    Color.Silver);
            e.DrawBackground();
            e.Graphics.DrawString(Configuration.Disciplines[0].Title??"..", 
                new Font(listTest.Font.FontFamily,13f, FontStyle.Bold), 
                Brushes.Black, new Point(e.Bounds.X+10,e.Bounds.Y-2) );
            e.Graphics.DrawString(Configuration.Disciplines[0].Descrition??"?", 
                new Font(listTest.Font.FontFamily, 11f, FontStyle.Regular), Brushes.DimGray,
                new RectangleF(e.Bounds.X+10,e.Bounds.Y+14, e.Bounds.Width-14, e.Bounds.Height), 
                new StringFormat{LineAlignment = StringAlignment.Near, Alignment = StringAlignment.Near} );
        }

        private TestUserControl test = null;
        private void startTest_Click(object sender, EventArgs e)
        {
            if (listTest.SelectedIndex < 0) return;
            Test t = (Test) listTest.Items[listTest.SelectedIndex];
            if (t == null) return;
            if (test != null) Controls.Remove(test);
            test?.Dispose();
            test = new TestUserControl(t);
            pListTest.Visible = false;
            Controls.Add(test);
            test.BringToFront();
            test.Dock = DockStyle.Fill;
            test.Finish+= TestOnFinish;
        }

        private void TestOnFinish(object sender, EventArgs e)
        {
            test.Visible = false;
            Test t = (Test)listTest.Items[listTest.SelectedIndex];
            if (t == null) return;
            List<string> res = new List<string>();

            for (var i = 0; i < t.Items.Count; i++)
            {
                Test.Item item = t.Items[i];
                res.Add($"{(i+1):00} Вопрос - {item.Question}");
                if(!test.testings[i].ret.All(s=>s))
                    res[res.Count - 1] += $"ОШИБКА [===========]";
                else
                {
                    res[res.Count - 1] += $"ОК [{t.Items[i].Answers.FirstOrDefault(s=>s.IsCorrect)?.Text}]";
                }
            }
            string file;
            File.WriteAllLines(file=$"result{DateTime.Now:yyyyMMdd-hhmmss}.txt",res,Encoding.UTF8);
            Process.Start(file);
        }

        private void listDisc_DrawItem(object sender, DrawItemEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

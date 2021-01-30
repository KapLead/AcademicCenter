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
        private TestUserControl _test;
        private bool _backend = true;
        
        public FormComplex()
        {
            InitializeComponent();
            Text +=@""""+Settings.Default.Discipline+ @"""";
        }
        public sealed override string Text
        {
            get => base.Text;
            set => base.Text = value;
        }
        private void Form1_Load(object sender, EventArgs e) => ConfigMenu();
        private void exit_Click(object sender, EventArgs e) => Close();
        private void settings_Click(object sender, EventArgs e) => new FormSettings().ShowDialog();
        private void ConfigMenu()
        {
            if(Configuration.Disciplines.Count==0) return;
            listTest.Items.Clear();
            listTest2.Items.Clear();
            listTest.Items.AddRange(Configuration.Disciplines[0]?.Tests?.ToArray());
            listTest2.Items.AddRange(Configuration.Disciplines[0]?.Tests?.ToArray());
            pListTest.Visible = true;
            Application.DoEvents();
            new FormStudent().ShowDialog();
            if (string.IsNullOrWhiteSpace(FormStudent.UserFamile) || string.IsNullOrWhiteSpace(FormStudent.UserFamile) ||
                string.IsNullOrWhiteSpace(FormStudent.UserFamile) || string.IsNullOrWhiteSpace(FormStudent.UserFamile))
            {
                MessageBox.Show(@"Введены не полные данные. Тестирование не возможно", @"Завершение работы");
                Close();
            }

            label2.Text = $@"Тестируемый : студент группы(класса) '{FormStudent.UserGroup}'
" +
                          $@"	{FormStudent.UserFamile} {FormStudent.UserName} {FormStudent.UserOtchestvo}
";

            if (listTest.Items.Count > 0)
            {
                listTest.SelectedIndex = listTest2.SelectedIndex = 0;
            }
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
            e.Graphics.DrawString(t.Title??"..", 
                new Font(listTest.Font.FontFamily,13f, FontStyle.Bold), 
                Brushes.Black, new Point(e.Bounds.X+10,e.Bounds.Y-2) );
            e.Graphics.DrawString(t.Descrition??"?", 
                new Font(listTest.Font.FontFamily, 11f, FontStyle.Regular), Brushes.DimGray,
                new RectangleF(e.Bounds.X+10,e.Bounds.Y+14, e.Bounds.Width-14, e.Bounds.Height), 
                new StringFormat{LineAlignment = StringAlignment.Near, Alignment = StringAlignment.Near} );
            e.Graphics.DrawString(t.Type.ToString(), 
                new Font(listTest.Font.FontFamily, 13f, FontStyle.Regular),
                t.Type==0?Brushes.RoyalBlue:Brushes.Green, new Point(e.Bounds.Right-150,e.Bounds.Y+5));
        }
        private void startTest_Click(object sender, EventArgs e)
        {
            if (listTest.SelectedIndex < 0) return;
            Test t = (Test) listTest.Items[listTest.SelectedIndex];
            if (t == null) return;
            if (_test != null) Controls.Remove(_test);
            _test?.Dispose();
            _test = new TestUserControl(t);
            pListTest.Visible = false;
            Controls.Add(_test);
            _test.BringToFront();
            _test.Dock = DockStyle.Fill;
            _test.Finish+= TestOnFinish;
        }
        private void TestOnFinish(object sender, EventArgs e)
        {
            Test t = (Test)listTest.Items[listTest.SelectedIndex];
            if (t == null)
            {
                _test.Visible = false;
                return;
            }
            List<string> res = new List<string>();
            res.Add($"\r\nТест: {t.Title} ({t.Descrition})");
            for (var i = 0; i < t.Items.Count; i++)
            {
                Item item = t.Items[i];
                res.Add($"{i+1} Вопрос - {item.Question}");
                if(!_test.testings[i].ret.All(s=>s))
                    res[res.Count - 1] += $"\t ОШИБКА [===========]";
                else
                {
                    res[res.Count - 1] += $"\t ВЕРНО [{t.Items[i].Answers.FirstOrDefault(s=>s.IsCorrect)?.Text}]";
                }
            }
            string file;
            File.WriteAllLines(file=$"result{DateTime.Now:yyyyMMdd-hhmmss}.txt",res,Encoding.UTF8);
            foreach (string s in res) label2.Text += s + Environment.NewLine;
            Process p = Process.Start(file);
            if (p != null)
            {
                p.EnableRaisingEvents = true;
                p.Exited += (o, args) =>
                {
                    _test.Invoke(new Action((() =>
                    {
                        _test.Visible = false;
                        pListTest.Visible = true;
                    })));
                };
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {
            _backend = !_backend;
            if(_backend) label2.SendToBack();
            else label2.BringToFront();
        }
        private void toolExit_Click(object sender, EventArgs e) => Close();
        private void тестыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pListTest.Visible = true;
            panelDocs.Visible = false;
        }
        private void toolDocs_Click(object sender, EventArgs e)
        {
            pListTest.Visible =false;
            panelDocs.Visible =true;
        }
        private void listTest2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listTest2.SelectedIndex < 0) return;
            Test t = (Test)listTest2.Items[listTest2.SelectedIndex];
            if (t == null) return;
            panelDoc.Controls.Clear();
            int i = 1;
            foreach (Item item in t.Items)
            {
                Label title = new Label 
                { 
                    Text =$@"{i++} {item.Question}", 
                    AutoEllipsis = true,
                    AutoSize = false,
                    Dock = DockStyle.Top
                };
                panelDoc.Controls.Add(title);
                title.BringToFront();
                List<Document> doc = new List<Document>();
                foreach (Answer answer in item.Answers)
                {
                    foreach (Document document in answer.Documents)
                    {
                        if (doc.All(d => d.Name != document.Name))
                            doc.Add(document);
                    }
                }
                if(doc.Count==0) 
                {
                    panelDoc.Controls.Add(new Label
                    {
                        Text = @"без документов",
                        ForeColor = Color.DimGray, 
                        AutoSize = false,
                        TextAlign = ContentAlignment.MiddleCenter
                    });
                    panelDoc.Controls[panelDoc.Controls.Count - 1].BringToFront();
                }
                else
                {
                    foreach (Document d in doc)
                    {
                        var b = new Button
                        {
                            Tag = d.Path,
                            Text = d.Name,
                            AutoSize = false,
                            Dock = DockStyle.Top,
                            ForeColor = Color.DimGray,
                            FlatStyle = FlatStyle.Flat,
                            TextAlign = ContentAlignment.MiddleLeft,
                            Padding = new Padding(10, 0, 0, 0),
                            FlatAppearance =
                            {
                                BorderSize = 0
                            }
                        };
                        panelDoc.Controls.Add(b);
                        b.BringToFront();
                        b.Click += (o, args) =>
                        {
                            var tag = ((Button) o)?.Tag;
                            if (tag != null) Process.Start(tag.ToString());
                        };
                    }
                }
            }
        }
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e) => new FormAbout().ShowDialog();
    }
}

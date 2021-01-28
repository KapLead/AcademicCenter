using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AcademicCenter
{
    public partial class TestItem : UserControl
    {
        public event EventHandler Ok;
        private Item item;
        private int height = 0;
        public TestItem(Item itm)
        {
            item = itm;
            InitializeComponent();
            lText.Text = item.Question;
            height += lText.Height + Padding.Top;
            Collapse();
            if(item.Answers.Count>0)
                foreach (Answer answer in item.Answers)
                {
                    Controls.Add(new CheckBox
                    {
                        Text = answer.Text, 
                        Checked = false, 
                        Padding = new Padding(10), 
                        AutoSize = false,
                        Height = 44,
                        Dock = DockStyle.Top
                    });
                    Controls[Controls.Count-1].BringToFront();
                    height += 44;
                }
            var disc = Configuration.Disciplines[0].Tests.FirstOrDefault(t => t.Items.Contains(item));
            if (disc?.Type == Type.Обучение)
            {
                height += 5;
                List<Document> doc = new List<Document>();
                foreach (Answer answer in item.Answers)
                {
                    foreach (Document document in answer.Documents)
                    {
                        if(doc.All(d => d.Name != document.Name))
                            doc.Add(document);
                    }
                }
                int x = Padding.Left;
                foreach (Document document in doc)
                {
                    LinkLabel l = new LinkLabel
                    {
                        Text = document.Name,
                        AutoSize = true, 
                        Padding = new Padding(4,4,4,8),
                        Height = 24, 
                        Left = x, Top = height
                    };
                    l.LinkClicked += (sender, args) =>
                    {
                        ((LinkLabel) sender).LinkVisited = true;
                        Process.Start(document.Path);
                    };
                    Controls.Add(l);
                    x += l.Width+5;
                }
                height += 5;
            }
            height += ok.Height + 20;
        }

        public List<CheckBox> GetAnswers()
        {
            return Controls.Cast<Control>().Where(c => c is CheckBox).Cast<CheckBox>().ToList();
        }
        public void Expand()
        {
            Height = height;
            ok.Visible = true;
            BorderStyle = BorderStyle.FixedSingle;
        }
        public void Collapse()
        {
            Height = lText.Height + Padding.Top;
            ok.Visible = false;
            BorderStyle = BorderStyle.None;
        }
        public void Select()
        {
            Expand();
        }

        public List<bool> ret = new List<bool>();
        private void ok_Click(object sender, System.EventArgs e)
        {
            ret.Clear();
            foreach (CheckBox box in GetAnswers())
            {
                var itm = item.Answers.FirstOrDefault(a => a.Text == box.Text);
                if(itm==null) ret.Add(false);
                else
                    ret.Add(box.Checked==itm.IsCorrect);
            }
            BackColor = (!ret.All(b => b)) ? Color.IndianRed : Color.LightGreen;
            var disc = Configuration.Disciplines[0].Tests.FirstOrDefault(t => t.Items.Contains(item));
            if (disc?.Type == Type.Обучение && !ret.All(b => b))
            {
                MessageBox.Show(@"Ответ не верный. Изучите материал по данной теме, и укажите правильный вариант ответа",
                    @"Не верный ответ");
                return;
            }
            Ok?.Invoke(sender,e);
            Collapse();
        }
    }
}

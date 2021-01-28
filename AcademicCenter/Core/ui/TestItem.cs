using System;
using System.Collections.Generic;
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
            Ok?.Invoke(sender,e);
            foreach (CheckBox box in GetAnswers())
            {
                var itm = item.Answers.FirstOrDefault(a => a.Text == box.Text);
                if(itm==null) ret.Add(false);
                else
                    ret.Add(box.Checked==itm.IsCorrect);
            }
            BackColor = (!ret.All(b => b)) ? Color.IndianRed : Color.LightGreen;
            Collapse();
        }
    }
}

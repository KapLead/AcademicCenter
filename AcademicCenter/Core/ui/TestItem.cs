using System.Windows.Forms;

namespace AcademicCenter
{
    public partial class TestItem : UserControl
    {
        private Test.Item item;
        public TestItem(Test.Item itm)
        {
            item = itm;
            InitializeComponent();
            lText.Text = item.Question;
            Collapse();
            if(item.Answers.Count>0)
                foreach (Test.Answer answer in item.Answers)
                {
                    Controls.Add(new CheckBox
                    {
                        Text = item.Question, 
                        Checked = false, 
                        Padding = new Padding(10), 
                        Dock = DockStyle.Top
                    });
                }
        }

        private void Expand()
        {
            Height = 
                
                button1.Visible = true;
        }

        private void Collapse()
        {
            Height = lText.Height + Padding.Top;
            button1.Visible = false;
        }
    }
}

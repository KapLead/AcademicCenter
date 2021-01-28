using System.Collections.Generic;
using System.Windows.Forms;
using System;

namespace AcademicCenter
{
    public partial class TestUserControl : UserControl
    {
        public event EventHandler Finish;
        private Test test = null;
        public List<TestItem> testings = new List<TestItem>();
        public int CurrentIndex { get; private set; } = 0;
        public TestUserControl(Test t)
        {
            test = t;
            InitializeComponent();
            foreach (Item item in test.Items)
                testings.Add(new TestItem(item){Dock=DockStyle.Top});
            foreach (TestItem item in testings)
            {
                Controls.Add(item);
                item.Dock = DockStyle.Top;
                item.BringToFront();
                item.Ok+= OnOk;
            }
            testings[0].Expand();
        }



        private void OnOk(object sender, EventArgs e)
        {
            if (CurrentIndex >= testings.Count - 1)
            {
                Finish?.Invoke(sender,e);
                testings[CurrentIndex].Collapse();
                return;
            }
            testings[CurrentIndex].Collapse();
            CurrentIndex++;
            testings[CurrentIndex].Expand();
            ScrollToControl(testings[CurrentIndex]);

        }
    }
}

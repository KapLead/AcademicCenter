using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AcademicCenter
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            Exp_books.ItemCheck -= checkedChange;
            Exp_discourse.ItemCheck -= checkedChange;
            Exp_laboratory.ItemCheck -= checkedChange;
            Exp_presentations.ItemCheck -= checkedChange;
            Exp_videos.ItemCheck -= checkedChange;
            foreach (KeyValuePair<string, bool> pair in Configuration.books?.Items)
                Exp_books.Items.Add(pair.Key, pair.Value);
            foreach (KeyValuePair<string, bool> pair in Configuration.discourse?.Items)
                Exp_discourse.Items.Add(pair.Key, pair.Value);
            foreach (KeyValuePair<string, bool> pair in Configuration.laboratory?.Items)
                Exp_laboratory.Items.Add(pair.Key, pair.Value);
            foreach (KeyValuePair<string, bool> pair in Configuration.presentations?.Items)
                Exp_presentations.Items.Add(pair.Key, pair.Value);
            foreach (KeyValuePair<string, bool> pair in Configuration.videos?.Items)
                Exp_videos.Items.Add(pair.Key, pair.Value);
            Exp_books.ItemCheck += checkedChange;
            Exp_discourse.ItemCheck += checkedChange;
            Exp_laboratory.ItemCheck += checkedChange;
            Exp_presentations.ItemCheck += checkedChange;
            Exp_videos.ItemCheck += checkedChange;
        }

        private void checkedChange(object sender, ItemCheckEventArgs e)
        {
            var clb = (CheckedListBox) sender;
            clb.ItemCheck -= checkedChange;
            clb.SetItemCheckState(e.Index,e.NewValue);
            clb.ItemCheck += checkedChange;
            string name = clb.Name.Replace("Exp_", null);
            var dic = typeof(Configuration).GetField(name).GetValue("Items");
            ((ExtensionVariable) dic).Items[clb.Items[e.Index].ToString()] = (e.NewValue==CheckState.Checked);
            JsonSettings.Save(dic, $"ext\\{name}");
        }

        private void Exp_discourse_Leave(object sender, EventArgs e) => ((CheckedListBox) sender).SelectedIndex = -1;
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademicCenter
{
    public partial class FormStudent : Form
    {
        public static string UserFamile { get; private set; }
        public static string UserName { get; private set; }
        public static string UserOtchestvo { get; private set; }
        public static string UserGroup { get; private set; }
        
        public FormStudent()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            UserFamile = fam.Text;
            UserName = name.Text;
            UserOtchestvo = otch.Text;
            UserGroup = @group.Text;
            if (string.IsNullOrWhiteSpace(UserFamile) ||
                string.IsNullOrWhiteSpace(UserFamile) ||
                string.IsNullOrWhiteSpace(UserFamile) ||
                string.IsNullOrWhiteSpace(UserFamile))
            {
                MessageBox.Show(@"Введены не полные данные. Заполните все поля!",@"Внимание");
                return;
            }
            Close();
        }
    }
}

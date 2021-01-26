using System;
using System.Windows.Forms;

namespace AcademicCenter
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Configuration.Initialization();
            Application.Run(new FormComplex());
        }
    }
}

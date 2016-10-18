using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RobControl
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormLogin dlg = new FormLogin();
            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            Application.Run(new FormMetro());
        }
    }
}

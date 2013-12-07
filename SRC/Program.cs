using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Infinite_Awaiting_challenge_fixer_for_Quake3 {
    static class Program {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_main());
        }
    }
}

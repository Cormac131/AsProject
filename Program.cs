using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewGame
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            StreamReader userCount = new StreamReader(FrmRegister.textFileName);
            UserCount = int.Parse(userCount.ReadLine());
            userCount.Close();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLauncher());
        }

        public static int UserCount;
        public static int totalTime = 0;
    }
}

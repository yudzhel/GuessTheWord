using System;
using System.Windows.Forms;

namespace GuessTheWord
{
    internal static class Program
    {
        public static Home home;
        public static Play play;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            home = new Home();
            Application.Run(home);
        }
    }
}

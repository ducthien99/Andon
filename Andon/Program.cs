using System;
using System.Windows.Forms;

namespace Andon.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.UnhandledException += UnhandledException;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MAIN());
           
        }

        static void UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var exc = e.ExceptionObject as Exception;
            if (exc != null)
            {
                MessageBox.Show(exc.ToString(),"error", MessageBoxButtons.OK);
            }
            Control.plc.SetDevice("M5", 1);
            Control.plc.SetDevice("M5", 0);

            // Can't continue, so quit the application:
            Environment.Exit(-1);
        }

    }
}

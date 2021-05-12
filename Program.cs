using System;
using System.Globalization;
using System.Windows.Forms;

namespace demo_organizer
{
    static class Program
    {
        static public MainWindow Window;

        //static public SettingsWindow Settings { get; set; } = new SettingsWindow();

        [STAThread]
        static void Main()
        {
            CultureInfo.CurrentCulture = new CultureInfo("en-US", false);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Window = new MainWindow();
            Application.Run(Window);
        }
    }
}

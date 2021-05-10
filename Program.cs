using System;
using System.Windows.Forms;

namespace demo_manager
{
    static class Program
    {
        static public MainWindow Window;

        //static public SettingsWindow Settings { get; set; } = new SettingsWindow();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Window = new MainWindow();
            Application.Run(Window);
        }
    }
}

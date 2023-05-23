

using System.Windows.Forms;
namespace Bank_System
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Splash());
            //Application.Run(new Login());
            //Application.Run(new EmployeeMenu());
            //Application.Run(new Statistics());
            Application.Run(new Login());
           // Application.Run(new AddBranch());
        }
    }
}
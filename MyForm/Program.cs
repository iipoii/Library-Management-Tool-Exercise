using MyForm.Class;
using MyForm.Forms;
using MyForm.Forms.Admin;

namespace MyForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            TemporaryDatabase.InitializeDataSet();
            Application.Run(new LogForm());
            TemporaryDatabase.ClearDataSet();
            //Application.Run(new GuestMdiContainer("guestUser"));
            //Application.Run(new AdminMdiContainer());
        }
    }
}
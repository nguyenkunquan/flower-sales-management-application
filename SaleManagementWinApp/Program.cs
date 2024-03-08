namespace SaleManagementWinApp
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
            //Application.Run(new frmLogin());
            //Application.Run(new frmProduct());
            //Application.Run(new frmUpdateCustomer("nguyenkunquan@gmail.com", "28102003"));
            Application.Run(new frmLogin());
        }
    }
}
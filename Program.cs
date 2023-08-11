namespace WinFormsApp2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()

        {
            //Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjYzNjE5M0AzMjMyMmUzMDJlMzBrTUFLbHZMT3NpN3Q5ZkptdE9xTnJOUzhxUytRZnV3aGcyVmdEelo5WUhjPQ==");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
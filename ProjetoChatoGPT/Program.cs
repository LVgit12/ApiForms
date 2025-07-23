namespace ProjetoChatoGPT
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            using (var splash = new frmSplash())
            {
                splash.ShowDialog();
            }

            Application.Run(new frmChatoGPT()); // frmMenu é o seu menu principal
        }

    }
}
namespace WinFormsAppTest9_2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //float n = 0.1f;
            //float n1 = 2.0f;
            //float n2 = n + n1;
            //decimal
            //double
            //MessageBox.Show(n2.ToString());
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
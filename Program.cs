namespace Test_task_Cars
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Views.FMain());
        }
    }
}
namespace Tyuiu.chernyhim.Sprint7.Project.V2
{
    internal static class Program
    {
       
        [STAThread]
        static void Main()
        {
            
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMain());
        }
    }
}
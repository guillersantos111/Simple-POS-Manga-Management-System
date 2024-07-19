using PosoManagementSystem.Controller_Design;
using PosoManagementSystem.Forms;


namespace PosoManagementSystem
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        
        }
    }
}

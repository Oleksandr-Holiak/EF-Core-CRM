using EF_Core_CRM.UI;

namespace EF_Core_CRM
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            bool isRunning = true;

            IMenu menu = new MainMenu();

            while (isRunning)
            {
                menu = await menu.Show();
            }
        }
    }
}

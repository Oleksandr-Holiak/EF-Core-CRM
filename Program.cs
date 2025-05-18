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
                await menu.Show();

                IMenu responceMenu = menu;
                while (menu == responceMenu)
                {
                    responceMenu = await menu.Get(Console.ReadLine());
                }
                menu = responceMenu;
            }
        }
    }
}

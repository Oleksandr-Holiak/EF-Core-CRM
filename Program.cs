using EF_Core_CRM.Database;
using EF_Core_CRM.Models;
using EF_Core_CRM.UI;
using Microsoft.EntityFrameworkCore;

namespace EF_Core_CRM
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            await CreateStandardAdminAccount();

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

                if (menu == null) isRunning = false;
            }
        }
        public static async Task CreateStandardAdminAccount()
        {
            string adminEmail = "admin@gmail.com";
            using EntityDatabase db = new EntityDatabase();

            if (!await db.Users.Where(u => u.Email == adminEmail).AnyAsync())
            {
                User admin = new User()
                {
                    FullName = "Admin Admin",
                    Email = adminEmail
                };
                await db.Users.AddAsync(admin);

                await db.SaveChangesAsync();

                ConsoleHelper.WriteSuccess("Added admin account");
            }
        }
    }
}

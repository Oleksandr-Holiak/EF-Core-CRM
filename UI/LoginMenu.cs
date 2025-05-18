using EF_Core_CRM.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Core_CRM.UI.WorkerMenus;
namespace EF_Core_CRM.UI
{
    class LoginMenu : IMenu
    {
        private string? _login;
        private string? _password;
        public async Task Show()
        {
            Console.WriteLine(
                "Log in screen\n" +
                "Enter your login or 1 to exit to main menu");
        }
        public async Task<IMenu> Get(string input)
        {
            int intResult = input.ParseToInt();

            if (intResult == 1) return new MainMenu();

            if (_login == null)
            {
                _login = input;
                Console.WriteLine("Enter your password");
                return this;
            }
            else
            {
                _password = input;

                bool logInStatus = await AccountManager.LogIn(_login);

                if (logInStatus)
                {
                    ConsoleHelper.WriteSuccess("Successfully logged in");
                    return new WorkerMenu();
                }
                else
                {
                    ConsoleHelper.WriteError("Wrong email or password");
                    return new LoginMenu();
                }
            }
        }
    }
}

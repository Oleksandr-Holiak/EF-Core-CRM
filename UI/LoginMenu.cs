using EF_Core_CRM.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                "Enter your login");
        }
        public async Task<IMenu> Get(string input)
        {
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

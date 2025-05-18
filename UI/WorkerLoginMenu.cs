using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_CRM.UI
{
    class WorkerLoginMenu : IMenu
    {
        private string? _login;
        private string? _password;
        public async Task Show()
        {
            if (_login == null)
            {
                Console.WriteLine(
                    "You are trying to login as worker\n" +
                    "Enter your login");
            }
            else if (_password == null)
            {
                Console.WriteLine("Enter your password");
            }
        }
        public async Task<IMenu> Get(string input)
        {
            if (_login == null)
            {
                _login = input;
                return this;
            }
            else if (_password == null)
            {
                _password = input;
                return this;
            }
            return new MainMenu();
        }
    }
}

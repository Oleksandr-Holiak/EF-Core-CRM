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
                "You are trying to login as worker\n" +
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
                return new WorkerMenu();
            }
        }
    }
}

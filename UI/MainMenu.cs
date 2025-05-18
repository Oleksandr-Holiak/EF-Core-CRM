using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_CRM.UI
{
    class MainMenu : IMenu
    {
        public async Task Show()
        {
            Console.WriteLine(
                "Welcome to CRM system\n" +
                "1. Log in\n" +
                "2. Exit");
        }
        public async Task<IMenu> Get(string input)
        {
            int number = input.ParseToInt();

            switch (number)
            {
                case 1:
                    return new LoginMenu();
                case 2:
                    return null;
                default:
                    ConsoleHelper.WriteError("Wrong selection");
                    return this;
            }
        }
    }
}

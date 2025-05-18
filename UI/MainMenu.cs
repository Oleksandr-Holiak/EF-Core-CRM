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
                "Who are you?\n" +
                "1. I am customer\n" +
                "2. I am worker");
        }
        public async Task<IMenu> Get(string input)
        {
            int number;

            bool success = int.TryParse(input, out number);

            switch (number)
            {
                case 1:
                    return this;
                case 2:
                    return this;
                default:
                    Console.WriteLine("Wrong selection");
                    return this;
            }
        }
    }
}

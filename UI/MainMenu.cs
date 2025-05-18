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
        public async Task<IMenu> Show()
        {
            Console.WriteLine(
                "Welcome to CRM system\n" +
                "Who are you?\n" +
                "1. I am customer\n" +
                "2. I am worker");

            string? response = Console.ReadLine();

            int number;

            bool success = int.TryParse(response, out number);

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

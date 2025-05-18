using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_CRM.UI
{
    class CustomerMenu : IMenu
    {
        public async Task Show()
        {
            Console.WriteLine(
                "Customer menu\n" +
                "1. Track my orders\n" +
                "2. Log out and exit to main menu");
        }
        public async Task<IMenu> Get(string input)
        {
            int result = input.ParseToInt();

            switch (result)
            {
                case 1:
                    throw new NotImplementedException();
                case 2:
                    return new MainMenu();
                default:
                    ConsoleHelper.WriteError("Wrong selection");
                    return this;
            }
        }
    }
}

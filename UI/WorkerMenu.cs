using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_CRM.UI
{
    class WorkerMenu : IMenu
    {
        public async Task Show()
        {
            Console.WriteLine(
                "Worker menu\n" +
                "1.Create new order\n" +
                "2.Edit order\n" +
                "3.Track your customer's orders\n" +
                "4.Create new user\n" +
                "5.Log out and return to main menu");
        }
        public async Task<IMenu> Get(string input)
        {
            int result = input.ParseToInt();

            switch (result)
            {
                case 1:
                    return this;
                case 2:
                    return this;
                case 3:
                    return this;
                case 4:
                    return this;
                case 5:
                    return new MainMenu();
                default:
                    return this;
            }
        }
    }
}

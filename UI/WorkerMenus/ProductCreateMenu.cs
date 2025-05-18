using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_CRM.UI.WorkerMenus
{
    class ProductCreateMenu : IMenu
    {
        public async Task Show()
        {
            Console.WriteLine(
                "Enter product name");
        }
        public async Task<IMenu> Get(string input)
        {
            string fullName = input;
        }
    }
}

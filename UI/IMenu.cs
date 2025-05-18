using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_CRM.UI
{
    public interface IMenu
    {
        Task Show();
        Task<IMenu> Get(string input);
    }
}

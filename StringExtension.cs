using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_CRM
{
    static class StringExtension
    {
        public static int ParseToInt(this string str)
        {
            int result = 0;

            int.TryParse(str, out result);

            return result;
        }
    }
}

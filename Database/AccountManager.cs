using EF_Core_CRM.Models;
using EF_Core_CRM.UI;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_CRM.Database
{
    class AccountManager
    {
        private static IAccount? _account;

        public static async Task<bool> LogIn(string _email)
        {
            using EntityDatabase db = new EntityDatabase();
            
            _account = await db.Customers.Where(u => u.Email == _email).SingleOrDefaultAsync();
            
            if (_account is not null) _account = await db.Users.Where(u => u.Email == _email).FirstAsync();

            return _account is not null;
        }
        public static async Task LogOut()
        {
            _account = null;
        }
    }
}

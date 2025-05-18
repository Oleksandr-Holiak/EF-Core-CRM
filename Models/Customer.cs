using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Core_CRM.Database;

namespace EF_Core_CRM.Models
{
    class Customer : IAccount
    {
        public int Id { get; set; }
        public required string FullName { get; set; }
        public required string Email { get; set; }
        public required string Adress { get; set; }
    }
}

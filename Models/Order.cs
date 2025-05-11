using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_CRM.Models
{
    class Order
    {
        public int Id { get; set; }
        public required int CustomerId { get; set; }
        public required int SalesRepresentativeId { get; set; }
        public User SalesRepresentative { get; set; }
        public required DateTime OrderDate { get; set; }
        public required decimal TotalAmount { get; set; }

    }
}

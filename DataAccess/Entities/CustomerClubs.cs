using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class CustomerClubs
    {
        public int Id { get; set; }

        public string CustomerId { get; set; }
        
        public string CustomerName { get; set; }

        public int ClubId { get; set; }

        public int Step { get; set; }

        public int Qty { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal Price { get; set; }

        public decimal TotalAmount { get; set; }

        public string? ReferalCode { get; set; }

        public DateTime? RegisterDate { get; set; }

        public DateTime? StartWeek { get; set; }

        public DateTime? EndWeek { get; set; }

        public string? Status { get; set; } // [1] Buy Package Pending [2]  Package Active 

        public bool IsActive { get; set; }
    }
}

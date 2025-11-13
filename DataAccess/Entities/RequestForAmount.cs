using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class RequestForAmount
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public decimal Amount { get; set; }

        public DateTime RequestDate { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public string PaymentType { get; set; }  // GooglePay , UPI / Bank Account

        public string MobileNo { get; set; }
        public string UPI { get; set; }
        public string BankAccount { get; set; }
        public string IFSC { get; set; }


        public string Status { get; set; } // Requested / Paid / Reject

    }
}

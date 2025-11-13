using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }

        public string? UserId { get; set; }

        public string? ContactNo { get; set; }

        public int? MerchantId { get; set; }

        public string RefBy { get; set; }

        public decimal Amount { get; set; }

        public DateTime PaymentDate { get; set; } = DateTime.UtcNow;

        [MaxLength(50)]
        public string? PaymentMode { get; set; }

        [MaxLength(100)]
        public string? TransactionId { get; set; }

        [MaxLength(100)]
        public string? OrderId { get; set; }

        public string? Status { get; set; }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class CompanyBankDetails
    {
        public int Id { get; set; }
        public int? CompanyId { get; set; }
        public string BankName { get; set; }
        public string BankAccountNo { get; set; }
        public string IFSC { get; set; }
        public bool? IsActivated { get; set; }
    }
}

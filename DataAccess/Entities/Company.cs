using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Company
    {
        public int Id { get; set; }
        public string? CompanyName { get; set; }
        public string? ShortDescription { get; set; }
        public string? LongDescription { get; set; }
        public string? CompanyLogo { get; set; }
        public string? MobileNo { get; set; }
        public string? EmailId { get; set; }
        public string? WhatsAppNo { get; set; }
        public string? TelegramNo { get; set; }
    }
}

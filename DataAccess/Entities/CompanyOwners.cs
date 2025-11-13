using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class CompanyOwners
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Gender { get; set; }
        public string EmailId { get; set; }
        public string MobileNo { get; set; }
        public string CompanyPost { get; set; } // Like Manager, CEO
        public string Description { get; set; }
        public string ProductImage { get; set; }
    }
}

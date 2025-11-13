using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class ContactUs
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Please enter yourname")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Please enter email Id")]
        public string EmailId { get; set; }

        [Required(ErrorMessage = "Please enter phoneNo")]
        public string PhoneNo { get; set; }

        public string Subject { get; set; }

        public string Message { get; set; }

    }
}

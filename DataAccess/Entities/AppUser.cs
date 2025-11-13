using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class AppUser : IdentityUser
    {
        public string? ParentId { get; set; }

        public string? FirstName { get; set; }

        public string? MiddleName { get; set; }

        public string? LastName { get; set; }

        public string? Description { get; set; }

        public string? Status { get; set; }

        [Precision(18, 2)]
        public decimal? Price { get; set; }

        public string? ReferalCode { get; set; } //  Customer Code

        public string? ReferalBy { get; set; } // Reference Person Name

        public string? ReferalCodeBy { get; set; } // Referal Code for reference user

        public DateTime? RegisterDate { get; set; }

        public DateTime? ExpiryDate { get; set; }

        public string? txtPassword { get; set; }

        [Precision(18, 2)]
        public decimal? EarnAmount { get; set; } = 0;

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public DateTime? UpdateDate { get; set; }

        public string? CreatedBy { get; set; }

        public string? UpdatedBy { get; set; }

        public string? MobileNo { get; set; }

        public bool? IsActivated { get; set; }

        public string? ImageUploadPath { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }

        public int SeedId { get; set; }
    }
}

using DataAccess.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class ApplicationDBContext : IdentityDbContext
    {
        public ApplicationDBContext() 
        {
        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Blogs> Blogs { get; set; }
        public DbSet<ClubManager> ClubManager { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<CompanyAccountFund> CompanyAccountFund { get; set; }
        public DbSet<CompanyBankDetails> CompanyBankDetails { get; set; }
        public DbSet<CompanyOwners> CompanyOwners { get; set; }
        public DbSet<ContactUs> ContactUs { get; set; }
        public DbSet<CustomerClubs> CustomerClubs { get; set; }
        public DbSet<Earning> Earning { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<PolicyText> PolicyText { get; set; }
        public DbSet<RequestForAmount> RequestForAmount { get; set; }
        public DbSet<SeedingHistory> SeedingHistory { get; set; }
        public DbSet<TermCondition> TermCondition { get; set; }
        public DbSet<UserWallet> UserWallet { get; set; }

    }
}

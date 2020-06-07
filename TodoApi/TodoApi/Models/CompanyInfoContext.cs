using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class CompanyInfoContext : DbContext
    {
        public CompanyInfoContext(DbContextOptions<CompanyInfoContext> options)
            : base(options) { }
        public DbSet<CompanyInfo>CompanyInfos {get;set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CompanyInfo>()
                .OwnsMany(property => property.companies);
        }

        public IEnumerable<CompanyInfo> getRusCompanies()
        {
            return
                from r in CompanyInfos
                where r.Country == "Russia"
                select r;
        }

    }
}

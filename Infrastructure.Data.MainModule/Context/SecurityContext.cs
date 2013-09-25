using System.Data.Entity;
using Domain.MainModule.Entities;

namespace Infrastructure.Data.MainModule.Context
{
    public class SecurityContext : DbContext
    {
        // public DbSet<SecurityProfile> SecurityProfiles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            // modelBuilder.Entity<SecurityProfile>().ToTable("dbo.SecurityProfile");
        }
    }
}

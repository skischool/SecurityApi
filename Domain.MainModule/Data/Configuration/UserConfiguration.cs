using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using Domain.MainModule.Entities;

namespace Domain.MainModule.Data.Configuration
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            this.Property(p => p.Id).HasColumnOrder(0);

            //this.Property(p => p.ClientToken).IsRequired();

            this.Property(p => p.Username)
                .IsRequired().HasMaxLength(200);

            this.HasMany(a => a.Roles)
                .WithMany(b => b.Users).Map(m =>
                {
                    m.MapLeftKey("UserId");
                    m.MapRightKey("RoleId");
                    m.ToTable("webpages_UsersInRoles");
                });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using Domain.MainModule.Entities;

namespace Domain.MainModule.Data.Configuration
{
    public class RoleConfiguration : EntityTypeConfiguration<Role>
    {
        public RoleConfiguration()
        {
            this.ToTable("webpages_Roles");
            this.Property(p => p.RoleName)
                .HasMaxLength(256).IsRequired();
        }
    }
}

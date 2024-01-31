using BusinessObject.BusinessObject;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.FluentAPI
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Role");
            builder.HasKey(x => x.RoleID);
            builder.Property(x => x.RoleName);
            builder.HasMany(x => x.Users).WithOne(x => x.Role).OnDelete(DeleteBehavior.NoAction);



        }


    }
}

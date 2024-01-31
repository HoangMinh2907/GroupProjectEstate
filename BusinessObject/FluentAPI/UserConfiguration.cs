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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(x => x. UserID);
            builder.Property(x => x.UserName);
            builder.Property(x => x.Password);
            builder.Property(x => x.FullName);
            builder.Property(x => x.Email);
            builder.Property(x => x.PhoneNumber);
            builder.HasMany(x => x.Comments).WithOne(x => x.User).OnDelete(DeleteBehavior.NoAction);

        }
    }


}

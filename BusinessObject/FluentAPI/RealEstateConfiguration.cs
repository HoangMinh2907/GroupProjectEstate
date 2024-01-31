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
    public class RealEstateConfiguration : IEntityTypeConfiguration<RealEstate>
    {
        public void Configure(EntityTypeBuilder<RealEstate> builder)
        {
            builder.ToTable("RealEstate");
            builder.HasKey(x => x.RealEstateID);
            builder.Property(x => x.RealEstateName);
            builder.Property(x => x.RealEstateAddress);
            builder.Property(x => x .Estimation);
            builder.Property(x => x.Description);
            builder.Property(x => x.Status);
            builder.HasMany(x => x.Autions).WithOne(x => x.RealEstate).OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(x => x.Comments).WithOne(x => x.RealEstate).OnDelete(DeleteBehavior.NoAction);




        }

    }
}

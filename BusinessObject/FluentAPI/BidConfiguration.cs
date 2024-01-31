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
    public class BidConfiguration : IEntityTypeConfiguration<Bid>
    {
        public void Configure(EntityTypeBuilder<Bid> builder)
        {
            builder.ToTable("Bid");
            builder.HasKey(x => x.BidID);
            builder.Property(x => x.BidAmount);
            builder.HasMany(x => x.Auctions).WithOne(x => x.Bid).OnDelete(DeleteBehavior.NoAction);


        }
    }
}

using BusinessObject.BusinessObject;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.FluentAPI
{
    public class AuctionConfiguration : IEntityTypeConfiguration<Auction>
    {
        public void Configure(EntityTypeBuilder<Auction> builder)
        {

            builder.ToTable("Auction");
            builder.HasKey(x => x.AuctionID);
            builder.Property(x => x.DateStart);
            builder.Property(x => x.DateEnd);
            builder.Property(x => x.AuctionType);
            builder.Property(x => x.DepositeAmount);
            builder.Property(x => x.FeeAmount);
            builder.Property(x => x.Status);




        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.BusinessObject
{
    public class TheRealEstateDBContext : DbContext
    {
        public TheRealEstateDBContext()
        {
            
        }

        public TheRealEstateDBContext(DbContextOptions<TheRealEstateDBContext> opt) : base(opt) { }

        public virtual DbSet<Role>? Roles { get; set; }
        public virtual DbSet<Auction>? Auctions { get; set; }
        public virtual DbSet<Bid>? Bids{ get; set; }
        public virtual DbSet<Comment>? Comments { get; set; }
        public virtual DbSet<User>? Users { get; set; }
        public virtual DbSet<RealEstate>? RealEstates { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(GetConnectionString());
        }

        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            return config["ConnectionStrings:DB"]!;
        }
    }
}

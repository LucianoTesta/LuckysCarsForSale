using LuckysCarsForSale.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace LuckysCarsForSale.Data
{
    public partial class LuckysCarsForSaleDbContext : DbContext
    {

        public LuckysCarsForSaleDbContext(DbContextOptions<LuckysCarsForSaleDbContext> options): base(options){}
        public DbSet<Car> Cars { get; set; }
        public DbSet<Buyer> Buyers { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<StatusHistory> StatusHistory { get; set; }

      
    }
}

using Microsoft.EntityFrameworkCore;
using WaterBilling.Api.Customers.Entities;
using WaterBilling.Api.Infrastructure.Entities;
using WaterBilling.Api.WaterUsage.Entities;

namespace WaterBilling.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
            
        }

        public DbSet<Customer> Customers => Set<Customer>();
        public DbSet<Meter> Meters => Set<Meter>();
        public DbSet<Zone> Zones => Set<Zone>();
    }
}
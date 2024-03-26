using EcoInvestAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace EcoInvestAPI.Data
{
    public class DbContextClass : DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> options) : base(options) 
        { }
        public DbSet<Company> Company { get; set; }

        public DbSet<Date> Date { get; set; }

        public DbSet<ClimateData> ClimateData { get; set; }

        public DbSet<StockData> StockData { get; set; }
    }
}

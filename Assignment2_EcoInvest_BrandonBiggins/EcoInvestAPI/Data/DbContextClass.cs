using EcoInvestAPI.Entities;
using EcoInvestAPI.Entities.NewEntities;
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

       // public DbSet<CompanyClimateData> CompanyClimateData { get; set; }

       // public DbSet<CompanyStockData> CompanyStockData { get; set; }

        public DbSet<CompanyRatings> CompanyRatingData { get; set; }

        public DbSet<CompanyClimateandStock> CompanyClimateandStock { get; set; }

        public DbSet<StockDataByDateRange> StockDataByDateRanges { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<StockDataByDateRange>().HasNoKey();

        }
    }
}

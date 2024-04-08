using EcoInvestAPI.Data;
using EcoInvestAPI.Entities;
using EcoInvestAPI.Entities.NewEntities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace EcoInvestAPI.Repositories.NewRepo
{
    public class StockDataByDateRangeService : IStockDataByDateRangeService
    {
        private readonly DbContextClass _dbContextClass;

        public StockDataByDateRangeService(DbContextClass dbContextClass)
        {
            this._dbContextClass = dbContextClass;
        }

        public async Task<List<StockDataByDateRange>> GetStockDataByDateRangeAsync(int companyId, DateTime startDate, DateTime endDate)
        {
            var companyParam = new SqlParameter("@CompanyID", companyId);
            var startDateParam = new SqlParameter("@StartDate", startDate);
            var endDateParam = new SqlParameter("@EndDate", endDate);

            return await _dbContextClass.Set<StockDataByDateRange>()
                .FromSqlRaw("EXEC dbo.spGetStockDataByDateRange @CompanyID, @StartDate, @EndDate", companyParam, startDateParam, endDateParam)
                .ToListAsync();
        }

    }
}

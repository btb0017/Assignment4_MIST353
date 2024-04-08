using EcoInvestAPI.Entities.NewEntities;

namespace EcoInvestAPI.Repositories.NewRepo
{
    public interface IStockDataByDateRangeService
    {
        Task<List<StockDataByDateRange>> GetStockDataByDateRangeAsync(int companyId, DateTime startDate, DateTime endDate);
    }
}

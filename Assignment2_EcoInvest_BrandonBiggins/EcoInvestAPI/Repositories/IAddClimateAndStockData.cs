using EcoInvestAPI.Entities;

namespace EcoInvestAPI.Repositories
{
    public interface IAddClimateAndStockData
    {
        Task<List<Company>> AddClimateAndStockData(int CompanyID, DateTime DateValue, double AvgTemperature);
    }
}


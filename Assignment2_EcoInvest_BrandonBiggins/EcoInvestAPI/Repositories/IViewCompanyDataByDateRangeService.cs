using EcoInvestAPI.Entities;
//Brandon Biggins
namespace EcoInvestAPI.Repositories
{
    public interface IViewCompanyDataByDateRangeService
    {
        Task<List<CompanyClimateData>> ViewCompanyDataByDateRange(int companyId, string startDate, string endDate);
    }
}

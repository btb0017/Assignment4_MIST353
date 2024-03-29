using EcoInvestAPI.Entities;
//Brandon Biggins
namespace EcoInvestAPI.Repositories
{
    public interface IViewCompanyDataByDateRangeService
    {
        Task<List<CompanyClimateandStock>> ViewCompanyDataByDateRange(int companyId, string startDate, string endDate);
    }
}

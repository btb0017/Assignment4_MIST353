using EcoInvestAPI.Entities;
//Brandon Biggins
namespace EcoInvestAPI.Repositories
{
    public interface IViewCompanyDataByDateRangeService
    {
        Task<List<Company>> ViewCompanyDataByDateRange(int companyId, string startDate, string endDate);
    }
}

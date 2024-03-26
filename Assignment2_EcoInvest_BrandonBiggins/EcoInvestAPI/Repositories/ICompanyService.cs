using EcoInvestAPI.Entities;

namespace EcoInvestAPI.Repositories
{
    public interface ICompanyService
    {
        Task<List<Company>> GetCompanyDetails(int companyId);
    }
}

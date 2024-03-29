using EcoInvestAPI.Entities;
//Brandon Biggins
namespace EcoInvestAPI.Repositories
{
    public interface ICompanyService
    {
        Task<List<Company>> GetCompanyDetails(int companyId);
    }
}

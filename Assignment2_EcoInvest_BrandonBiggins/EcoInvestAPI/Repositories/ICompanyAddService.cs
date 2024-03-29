using EcoInvestAPI.Entities;
//Ryan Bankert
namespace EcoInvestAPI.Repositories
{
    public interface ICompanyAddService
    {
        public Task<int> AddCompany(Company company);
    }
}

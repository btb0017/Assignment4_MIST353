namespace EcoInvestAPI.Repositories
{
    public interface ICompanyService
    {
        public Task<List<CompanyService>> GetCompanyDetails(int companyId);
    }
}

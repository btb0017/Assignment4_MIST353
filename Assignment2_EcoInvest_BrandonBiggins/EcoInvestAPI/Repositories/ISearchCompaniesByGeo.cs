using EcoInvestAPI.Entities;

namespace EcoInvestAPI.Repositories
{
    public interface ISearchCompaniesByGeo
    {
        Task<List<Company>> SearchCompaniesByGeo(string CompanyLongitude, string CompanyLatitude);
    }
}

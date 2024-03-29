using EcoInvestAPI.Data;
using EcoInvestAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
//Ryan Bankert

namespace EcoInvestAPI.Repositories
{
    public class CompanyAddService : ICompanyAddService
    {
        private readonly DbContextClass _dbContextClass;

        public CompanyAddService(DbContextClass dbContextClass) => _dbContextClass = dbContextClass;

        public async Task<int> AddCompany(Company company)
        {
            var CompanyName = new SqlParameter("@CompanyName", company.CompanyName);

            var CompanyStreet = new SqlParameter("@CompanyStreet", company.CompanyStreet);

            var CompanyCity = new SqlParameter("@CompanyCity", company.CompanyCity);

            var CompanyState = new SqlParameter("@CompanyState", company.CompanyState);

            var CompanyCountry = new SqlParameter("@CompanyCountry", company.CompanyCountry);

            var CompanyZip = new SqlParameter("@CompanyZip", company.CompanyZip);

            var CompanyEmail = new SqlParameter("@CompanyEmail", company.CompanyEmail);

            var CompanyLatitude = new SqlParameter("@CompanyLatitude", company.CompanyLatitude);

            var CompanyLongitude = new SqlParameter("@CompanyLongitude", company.CompanyLongitude);

            var CompanyWebsite = new SqlParameter("@CompanyWebsite", company.CompanyWebsite);

            var CompanyClimateRating = new SqlParameter("@CompanyClimateRating", company.CompanyClimateRating);

            var CompanyDetails = await Task.Run(() => _dbContextClass.Database.ExecuteSqlRaw("spCompanyAdd @CompanyName, @CompanyStreet, @CompanyCity, @CompanyState, @CompanyCountry, @CompanyZip, @CompanyEmail, @CompanyLatitude, @CompanyLongitude, @CompanyWebsite, @CompanyClimateRating", 
                CompanyName, CompanyStreet, CompanyCity, CompanyState, CompanyCountry, CompanyZip,  CompanyEmail, CompanyLatitude, CompanyLongitude, CompanyWebsite, CompanyClimateRating));

        return CompanyDetails;
        }
    }
}

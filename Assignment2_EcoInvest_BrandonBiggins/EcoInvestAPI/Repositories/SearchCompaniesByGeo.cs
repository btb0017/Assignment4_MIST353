using EcoInvestAPI.Data;
using EcoInvestAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Threading.Tasks;
//Braylon Higginbotham

namespace EcoInvestAPI.Repositories
{
    public class SearchCompaniesByGeoContoller : ISearchCompaniesByGeo
    {
        private readonly DbContextClass _dbContextClass;

        public SearchCompaniesByGeoContoller(DbContextClass dbContextClass)
        {
            this._dbContextClass = dbContextClass;
        }

        public async Task<List<Company>> SearchCompaniesByGeo(string CompanyLongitude, string CompanyLatitude)
        {
            
            var lat1 = new SqlParameter("@CompanyLatitude", CompanyLatitude);
            var long1 = new SqlParameter("@CompanyLongitude", CompanyLongitude );

            var viewSearchCompaniesByGeo = await _dbContextClass.Company
                .FromSqlRaw("EXEC spSearchCompaniesByGeoLocation '25.7617', '-80.1918'", lat1, long1)
                .ToListAsync();
            return viewSearchCompaniesByGeo;
       }
    }
}

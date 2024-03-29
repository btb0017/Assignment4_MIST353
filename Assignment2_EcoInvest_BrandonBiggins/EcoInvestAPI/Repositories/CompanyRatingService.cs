using EcoInvestAPI.Data;
using EcoInvestAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
//Ryan Bankert

namespace EcoInvestAPI.Repositories
{
    public class CompanyRatingService: ICompanyRatingService
    {
        private readonly DbContextClass _dbContextClass;
        public CompanyRatingService(DbContextClass dbContextClass) => _dbContextClass = dbContextClass;
        public async Task<List<CompanyRatings>> GetCompanyClimateRating(int companyId)
        {
            var param = new SqlParameter("@CompanyID", companyId);

            var companyRatingData = await _dbContextClass.CompanyRatingData
                .FromSqlRaw("EXEC spGetCompanyClimateRating @CompanyID", param)
                .ToListAsync();

            return companyRatingData;
        }
    }
}

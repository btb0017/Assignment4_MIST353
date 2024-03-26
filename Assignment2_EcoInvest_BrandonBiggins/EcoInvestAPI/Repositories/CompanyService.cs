using EcoInvestAPI.Data;
using EcoInvestAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace EcoInvestAPI.Repositories
{
    public class CompanyService : ICompanyService
    {
        private readonly DbContextClass _dbContextClass;

        public CompanyService(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }

        public async Task<List<Company>> GetCompanyDetails(int companyId)
        {
            // Ensure the SqlParameter is correctly initialized
            var param = new SqlParameter("@CompanyID", companyId);

            // Directly await the ToListAsync call without using Task.Run for better efficiency
            var companyDetails = await _dbContextClass.Company
                .FromSqlRaw("EXEC spCompanyDetails @CompanyID", param)
                .ToListAsync();

            return companyDetails;
        }
    }
}

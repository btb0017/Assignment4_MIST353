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
        public async Task<List<CompanyService>> GetCompanyDetails(int companyId)
        {
            var param = new SqlParameter("@CompanyID", companyId);
            var companyDetails = await Task.Run(() => 
                    _dbContextClass.Company.FromSqlRaw("exec spGetCompanyDetails @CompanyID", param).ToListAsync());

            return companyDetails;
        }
    }
}

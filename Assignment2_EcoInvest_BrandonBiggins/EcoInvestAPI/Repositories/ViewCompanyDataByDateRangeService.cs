using EcoInvestAPI.Data;
using EcoInvestAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Threading.Tasks;
//Brandon Biggins

namespace EcoInvestAPI.Repositories
{
    public class ViewCompanyDataByDateRangeService : IViewCompanyDataByDateRangeService
    {
        private readonly DbContextClass _dbContextClass;

        public ViewCompanyDataByDateRangeService(DbContextClass dbContextClass)
        {
            this._dbContextClass = dbContextClass;
        }

        public async Task<List<CompanyClimateandStock>> ViewCompanyDataByDateRange(int companyId, string startDate, string endDate)
        {
            var param = new SqlParameter("@CompanyID", companyId);
            var date1 = new SqlParameter("@StartDate", startDate);
            var date2 = new SqlParameter("@EndDate", endDate);

            var viewCompanyClimateData = await _dbContextClass.companyClimateandStock
                .FromSqlRaw("EXEC spViewCompanyDataByDateRange @CompanyID, @StartDate, @EndDate", param, date1, date2)
                .ToListAsync();

            //var viewCompanyStockData = await _dbContextClass.CompanyStockData
              // .FromSqlRaw("EXEC spViewCompanyDataByDateRange @CompanyID, @StartDate, @EndDate", param, date1, date2)
               //.ToListAsync();

            return viewCompanyClimateData;

        }
    }
}

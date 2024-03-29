using EcoInvestAPI.Data;
using EcoInvestAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Threading.Tasks;
//Braylon Higginbotham

namespace EcoInvestAPI.Repositories
{
    public class AddClimateAndStockDataController : IAddClimateAndStockData
    {
        private readonly DbContextClass _dbContextClass;

        public AddClimateAndStockDataController(DbContextClass dbContextClass)
        {
            this._dbContextClass = dbContextClass;
        }

        public async Task<List<Company>> AddClimateAndStockData(int CompanyID, DateTime DateValue, double AvgTemperature)
        {

            var comp = new SqlParameter("@CompanyID", CompanyID);
            var Datavalue = new SqlParameter("@DateValue", DateValue);
            var Temp = new SqlParameter("@AvgTemperature", AvgTemperature);

            var viewAddClimateAndStockData = await _dbContextClass.Company
                .FromSqlRaw("EXEC AddClimateAndStockData @CompanyID = 1,    @DateValue = \"2023-01-20\",@AvgTemperature = 79.44", comp, Datavalue, Temp)
                .ToListAsync();
            return viewAddClimateAndStockData;
        }
    }
}

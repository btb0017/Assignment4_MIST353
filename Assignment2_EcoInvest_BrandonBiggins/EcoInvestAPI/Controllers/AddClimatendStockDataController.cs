using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EcoInvestAPI.Entities;
using EcoInvestAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
//Braylon Higginbotham
namespace EcoInvestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddClimateAndStockDataController : ControllerBase
    {
        private readonly IAddClimateAndStockData viewAddClimateAndStockData;

        public AddClimateAndStockDataController(IAddClimateAndStockData viewAddClimateAndStockData)
        {
            this.viewAddClimateAndStockData = viewAddClimateAndStockData;
        }

        [HttpGet("{CompanyID}/{DateValue}/{AvgTemperature}")]
        public async Task<IActionResult> AddClimateAndStockData(int CompanyID, DateTime DateValue, double AvgTemperature)
        {
            var companyStockAndClimateData = await viewAddClimateAndStockData.AddClimateAndStockData(CompanyID, DateValue, AvgTemperature);

            if (companyStockAndClimateData == null || companyStockAndClimateData.Count == 0)
            {
                return NotFound();
                
            }
            return Ok(companyStockAndClimateData);

        }
    }
}
using Microsoft.AspNetCore.Mvc;
using EcoInvestAPI.Repositories;
using EcoInvestAPI.Entities;
using EcoInvestAPI.Repositories.NewRepo;
using Microsoft.EntityFrameworkCore;

namespace EcoInvestAPI.Controllers.NewControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockDataController : Controller
    {
        private readonly IStockDataByDateRangeService _stockDataByDateRangeService;

        public StockDataController(IStockDataByDateRangeService stockDataByDateRangeService)
        {
            this._stockDataByDateRangeService = stockDataByDateRangeService;
        }

        // GET: api/StockData/5?startDate=2024-01-01&endDate=2024-01-31
        [HttpGet("{companyId}")]
        public async Task<IActionResult> GetStockDataByDateRange([FromQuery] int companyId, [FromQuery] DateTime startDate, [FromQuery] DateTime endDate)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var stockData = await _stockDataByDateRangeService.GetStockDataByDateRangeAsync(companyId, startDate, endDate);

                if (stockData == null || stockData.Count == 0)
                {
                    return NotFound();
                }

                return Ok(stockData);
            }
            catch (Exception ex)
            {
                // Log the exception
                return StatusCode(500, "Internal server error: " + ex.Message);
            }
        }
    }
}

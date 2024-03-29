using EcoInvestAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using EcoInvestAPI.Entities;
//Brandon Biggins
namespace EcoInvestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViewCompanyDataByDateRangeController : Controller
    {
        private readonly IViewCompanyDataByDateRangeService viewCompanyDataByDateRangeService;


        public ViewCompanyDataByDateRangeController(IViewCompanyDataByDateRangeService viewCompanyDataByDateRangeService)
        {
            this.viewCompanyDataByDateRangeService = viewCompanyDataByDateRangeService;
        }

        [HttpGet("{companyId}/{startDate}/{endDate}")]
        public async Task<ActionResult<List<CompanyClimateandStock>>> ViewCompanyDataByDateRange(int companyId, string startDate, string endDate)
        {
            var companyIDandDates = await viewCompanyDataByDateRangeService.ViewCompanyDataByDateRange(companyId, startDate, endDate);
            
            if (companyIDandDates == null || companyIDandDates.Count == 0) // Adjusted check
            {
                return NotFound();
            }
            return Ok(companyIDandDates); // Wrap in Ok for a 200 status code
        }
    }
}

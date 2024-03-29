using EcoInvestAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using EcoInvestAPI.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
// Brandon Biggins
namespace EcoInvestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase // Use ControllerBase for API controllers without views
    {
        private readonly ICompanyService companyService;

        public CompanyController(ICompanyService companyService)
        {
            this.companyService = companyService;
        }

        [HttpGet("{companyId}")]
        public async Task<ActionResult<List<Company>>> GetCompanyDetails(int companyId) // Adjusted return type
        {
            var companyDetails = await companyService.GetCompanyDetails(companyId);
            if (companyDetails == null || companyDetails.Count == 0) // Adjusted check
            {
                return NotFound();
            }
            return Ok(companyDetails); // Wrap in Ok for a 200 status code
        }
    }
}

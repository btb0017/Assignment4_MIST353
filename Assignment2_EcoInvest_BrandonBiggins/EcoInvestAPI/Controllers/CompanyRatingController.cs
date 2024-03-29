using EcoInvestAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using EcoInvestAPI.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel.Design;

// Ryan Bankert 
namespace EcoInvestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyRatingController : ControllerBase // Use ControllerBase for API controllers without views
    {
        private readonly ICompanyRatingService companyRatingService;
        public CompanyRatingController(ICompanyRatingService CompanyRatingService)
        {
            this.companyRatingService = CompanyRatingService;
        }
        [HttpGet("{companyId}")]
        public async Task<ActionResult<CompanyRatings>> GetCompanyClimateRating(int companyId) 
        {
            var companyDetails = await companyRatingService.GetCompanyClimateRating(companyId);
            if (companyDetails == null) // Check for null content with the companyId
            {
                return NotFound();
            }
            return Ok(companyDetails); // Return ok if content was found
        }
    }
}

using EcoInvestAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EcoInvestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : Controller
    {
        private readonly ICompanyService companyService;
        public CompanyController(ICompanyService companyService)
        {
            this.companyService = companyService;
        }
        [HttpGet("{companyId}")]
        public async Task<List<CompanyService>> GetCompanyDetails(int companyId)
        {
            var companyDetails = await companyService.GetCompanyDetails(companyId);
            /*if (companyDetails == null)
            {
                return NotFound();
            }*/
            return companyDetails;
        }
    }
}

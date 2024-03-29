using EcoInvestAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using EcoInvestAPI.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel.Design;
//Ryan Bankert

namespace EcoInvestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyAddController(ICompanyAddService companyAddService) : Controller

    {
        private readonly ICompanyAddService companyAddService = companyAddService;

        [HttpPost]
        public async Task<ActionResult<int>> AddCompany(Company company)
        {
            var companyDetails = await companyAddService.AddCompany(company); 
            if (companyDetails == 0) 
            {
                return NotFound();
            }
            return companyDetails;
        }
    }
}

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
    public class SearchCompaniesByGeoController : ControllerBase
    {
        private readonly ISearchCompaniesByGeo _viewSearchCompaniesByGeo;

        public SearchCompaniesByGeoController(ISearchCompaniesByGeo viewSearchCompaniesByGeo)
        {
            _viewSearchCompaniesByGeo = viewSearchCompaniesByGeo;
        }

        [HttpGet("{CompanyLongitude}/{CompanyLatitude}")]
        public async Task<IActionResult> ViewSearchCompaniesByGeo(string CompanyLongitude, string CompanyLatitude)
        {
            var companyLatandLong = await _viewSearchCompaniesByGeo.SearchCompaniesByGeo(CompanyLongitude, CompanyLatitude);

            if (companyLatandLong == null || companyLatandLong.Count == 0)
            {
                return Ok(companyLatandLong);
            }

            return NotFound();
        }
    }
}




using Microsoft.AspNetCore.Mvc;

namespace EcoInvestAPI.Controllers
{
    public class CompanyRatingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

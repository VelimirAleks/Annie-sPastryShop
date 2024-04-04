using Microsoft.AspNetCore.Mvc;

namespace Annie_sPastryShop.Controllers
{
    public class BlogController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

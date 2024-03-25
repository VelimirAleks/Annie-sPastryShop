using Microsoft.AspNetCore.Mvc;

namespace Annie_sPastryShop.Controllers
{
    public class ProductController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

﻿using Microsoft.AspNetCore.Mvc;

namespace Annie_sPastryShop.Areas.Admin.Controllers
{
    public class MainController : AdminBaseController
    {
        [HttpGet]
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}

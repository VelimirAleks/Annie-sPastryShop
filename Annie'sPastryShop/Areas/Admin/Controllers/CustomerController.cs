using AnniesPastryShop.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Annie_sPastryShop.Areas.Admin.Controllers
{
    public class CustomerController : AdminBaseController
    {
        private readonly ICustomerService customerService;

        public CustomerController(ICustomerService _customerService)
        {
            customerService = _customerService;
        }

        [HttpGet]
        public async Task <IActionResult> All()
        {
            var customers = await customerService.GetAllCustomersAsync();
            return View(customers);
        }

        [HttpGet]
        public async Task <IActionResult> Details(int id)
        {
            var customer = await customerService.GetCustomerByIdAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }
    }
}

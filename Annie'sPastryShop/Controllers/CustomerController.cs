using AnniesPastryShop.Core.Contracts;
using AnniesPastryShop.Core.Models.Customer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Annie_sPastryShop.Controllers
{
    public class CustomerController : BaseController
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly ICustomerService customerService;

        public CustomerController(UserManager<IdentityUser> _userManager, ICustomerService _customerService)
        {
            userManager = _userManager;
            customerService = _customerService;
        }

        [HttpGet]
        public IActionResult RegisterCustomer()
        {
            return View();
        }

        [HttpPost]
        [Route("Customer/RegisterCustomer")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegisterCustomer(RegisterCustomerViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(string.Empty, "Failed to create customer.");
                return View(model);
            }
            var user = await userManager.GetUserAsync(User);
            if (user == null)
            {
                ModelState.AddModelError(string.Empty, "User not found.");
                return View(model);
            }

            var registrationResult = await customerService.SaveAdditionalDetailsAsync(user.Id, model.FullName);
            if (!registrationResult)
            {
                ModelState.AddModelError(string.Empty, "Failed to create customer.");
                return View(model);
            }
            var cartCreationResult = await customerService.CreateCartAsync(user.Id);
            if (!cartCreationResult)
            {
                ModelState.AddModelError(string.Empty, "Failed to create cart.");
                return View(model);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}

using AnniesPastryShop.Core.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Annie_sPastryShop.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
        protected string GetUserId()
        {
            string id = string.Empty;

            if (User != null)
            {
                id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            }
            return id;
        }

        protected async Task<bool> IsCustomerAsync(ICustomerService customerService)
        {
            return await customerService.IsUserCustomerAsync(GetUserId());
        }
    }
}

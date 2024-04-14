using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static AnniesPastryShop.Infrastructure.Constants.DataConstants;

namespace Annie_sPastryShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = AdministratorRoleName)]
    public class AdminBaseController : Controller
    {

    }
}

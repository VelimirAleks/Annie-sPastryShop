using AnniesPastryShop.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Annie_sPastryShop.Controllers
{
    public class CartController : BaseController
    {
        private readonly ICartService cartService;
        private readonly ICustomerService customerService;

        public CartController(ICartService _cartService, ICustomerService _customerService)
        {
            cartService = _cartService;
            customerService = _customerService;
        }

        [HttpGet]
        public async Task <IActionResult> Cart()
        {
            var userId = GetUserId();
            var isCustomer = await IsCustomerAsync(customerService);
            if (!isCustomer)
            {
                return Unauthorized();
            }
            var cartViewModel=await cartService.GetCartAsync(userId);
            if (cartViewModel == null)
            {
                return NotFound();
            }
            return View(cartViewModel);
        }

        [HttpPost]
        public async Task<ActionResult> AddToCart(int productId,int quantity)
        {
            var userId = GetUserId();
            var isCustomer = await IsCustomerAsync(customerService);
            if (!isCustomer)
            {
                return Unauthorized();
            }
            if (productId<=0|| quantity<=0)
            {
                return BadRequest("Invalid product or quantity.");
            }
            try
            {
                var result = await cartService.AddProductToCartAsync(productId, quantity, userId);
                if (!result)
                {
                    return NotFound();
                }
                return Redirect(Request.Headers["Referer"].ToString());
            }
            catch (Exception )
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> RemoveFromCart(int cartItemId)
        {
            try
            {
                var result = await cartService.RemoveCartItemFromCartAsync(cartItemId);
                if (!result)
                {
                    return NotFound();
                }
                return RedirectToAction("Cart");
            }
            catch (Exception )
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> UpdateCartItemQuantity(int cartItemId, int newQuantity)
        {
            if (newQuantity <= 0)
            {
                return BadRequest("Invalid quantity.");
            }
            try
            {
                var result = await cartService.UpdateCartItemQuantityAsync(cartItemId, newQuantity);
                if (!result)
                {
                    return NotFound();
                }
                return RedirectToAction("Cart");
            }
            catch (Exception )
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> ClearCart()
        {
            var userId = GetUserId();
            var isCustomer = await IsCustomerAsync(customerService);
            if (!isCustomer)
            {
                return Unauthorized();
            }
            try
            {
                var result = await cartService.ClearCartAsync(userId);
                if (!result)
                {
                    return NotFound();
                }
                return RedirectToAction("Cart");
            }
            catch (Exception )
            {
                return BadRequest();
            }
        }

        [HttpGet]
        public async Task<int> GetCartItemCount()
        {
            var userId = GetUserId();
            var cartViewModel = await cartService.GetCartAsync(userId);
            return cartViewModel?.CartItems.Sum(ci => ci.Quantity) ?? 0;
        }
    }
}

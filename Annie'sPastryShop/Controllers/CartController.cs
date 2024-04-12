using AnniesPastryShop.Core.Contracts;
using Microsoft.AspNetCore.Authorization;
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
            
            cartViewModel.GrandTotal = cartViewModel.CartItems.Sum(ci => ci.TotalPrice);

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
            catch (Exception ex )
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RemoveFromCart(int productId)
        {
            try
            {
                var userId = GetUserId();
                var cartId = await customerService.GetCartIdForCustomerAsync(userId);

                var result = await cartService.RemoveCartItemFromCartAsync(productId, cartId);
                if (!result)
                {
                    return NotFound();
                }
                
                return RedirectToAction(nameof(Cart));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateCartItemQuantity(int productId, int newQuantity)
        {
            if (newQuantity <= 0)
            {
                return BadRequest("Invalid quantity.");
            }
            try
            {
                var userId = GetUserId();
                var cartId = await customerService.GetCartIdForCustomerAsync(userId);
                var result = await cartService.UpdateCartItemQuantityAsync(productId, cartId, newQuantity);
                if (!result)
                {
                    return NotFound();
                }
                return RedirectToAction(nameof(Cart));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
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

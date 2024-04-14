using AnniesPastryShop.Core.Contracts;
using AnniesPastryShop.Core.Models.Order;
using AnniesPastryShop.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace Annie_sPastryShop.Controllers
{
    public class OrderController : BaseController
    {
        private readonly IOrderServices orderServices;
        private readonly ICartService cartService;
        private readonly ICustomerService customerService;

        public OrderController(IOrderServices _orderServices, ICartService _cartService, ICustomerService _customerService)
        {
            orderServices = _orderServices;
            cartService = _cartService;
            customerService = _customerService;
        }

        [HttpGet]
        public async Task<IActionResult> Order()
        {
            var userId = GetUserId();
            var cart=await cartService.GetCartAsync(userId);
            if (cart == null)
            {
                return NotFound();
            }
            var cartId = cart.Id;

            var orderItems = cart.CartItems.Select(ci => new OrderItemViewModel
            {
                ProductId = ci.ProductId,
                ProductName = ci.ProductName,
                Quantity = ci.Quantity,
                TotalPrice = ci.TotalPrice
            }).ToList();

            var paymentMethods = await orderServices.GetAllPaymentMethodsAsync();

            var model = new OrderViewModel
            {
                OrderItems = orderItems,
                PaymentMethods = paymentMethods.ToList(),
                CartId = cartId
            };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Order(OrderViewModel model)
        {
            var userId = GetUserId();
            var isCustomer = await IsCustomerAsync(customerService);

            if (!isCustomer)
            {
                return Unauthorized();
            }

            var cart = await cartService.GetCartAsync(userId);
            if (model.OrderItems == null || !model.OrderItems.Any())
            {
                
                if (cart != null)
                {
                    model.OrderItems = cart.CartItems.Select(ci => new OrderItemViewModel
                    {
                        ProductId = ci.ProductId,
                        ProductName = ci.ProductName,
                        Quantity = ci.Quantity,
                        TotalPrice = ci.TotalPrice
                    }).ToList();
                }
            }

            if (!ModelState.IsValid)
            {
                model.PaymentMethods = await orderServices.GetAllPaymentMethodsAsync();
                return View(model);
            }
            int cartId = model.CartId;
            if (model.OrderItems == null || !model.OrderItems.Any())
            {
                ModelState.AddModelError("", "Please add items to your order.");
                model.PaymentMethods = await orderServices.GetAllPaymentMethodsAsync();

                if (cart != null)
                {
                    model.OrderItems = cart.CartItems.Select(ci => new OrderItemViewModel
                    {
                        ProductId = ci.ProductId,
                        ProductName = ci.ProductName,
                        Quantity = ci.Quantity,
                        TotalPrice = ci.TotalPrice
                    }).ToList();
                }
                return View(model);
            }

            var orderId = await orderServices.PlaceOrderAsync(model, cartId);

            if (orderId <= 0)
            {
                ModelState.AddModelError("", "Failed to place the order.");
                model.PaymentMethods = await orderServices.GetAllPaymentMethodsAsync();
                return View(model);
            }

            var clearCartResult = await cartService.ClearCartAsync(userId);
            if (!clearCartResult)
            {
                ModelState.AddModelError("", "Failed to clear the cart after placing the order.");
                return View(model);
            }

            return RedirectToAction("OrderConfirmation", new { orderId });
        }
        [HttpGet]
        public IActionResult OrderConfirmation(int orderId)
        {
            var model = new OrderConfirmationViewModel
            {
                OrderId = orderId,
                Message= "Thank you for your order! Your request has been successfully received. We will notify you once your order is processed and ready for delivery."
            };
            return View(model);
        }
    }
}

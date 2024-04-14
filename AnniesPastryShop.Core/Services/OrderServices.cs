using Annie_sPastryShop.Infrastructure.Data;
using AnniesPastryShop.Core.Contracts;
using AnniesPastryShop.Core.Models.Order;
using AnniesPastryShop.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AnniesPastryShop.Core.Services
{
    public class OrderServices : IOrderServices
    {
        private readonly ApplicationDbContext context;

        public OrderServices(ApplicationDbContext _context)
        {
            context = _context;
        }

        public async Task<IEnumerable<PaymentMethodViewModel>> GetAllPaymentMethodsAsync()
        {
            var paymentMethods = await context.PaymentsMethods
                .AsNoTracking()
                .Select(pm => new PaymentMethodViewModel
                {
                    Id = pm.Id,
                    Name = pm.Name,
                })
                .ToListAsync();
            return paymentMethods;
        }

        public async Task<PaymentMethodViewModel?> GetPaymentMethodByIdAsync(int id)
        {
            var paymentMethod = await context.PaymentsMethods
                .AsNoTracking()
                .Where(pm => pm.Id == id)
                .Select(pm => new PaymentMethodViewModel
                {
                    Id = pm.Id,
                    Name = pm.Name,
                })
                .FirstOrDefaultAsync();
            return paymentMethod;
        }

        public async Task<int> PlaceOrderAsync(OrderViewModel model, int cartId, decimal grandTotalPrice, int customerId)
        {
            var paymentMethod = await context.PaymentsMethods.FindAsync(model.PaymentMethod.Id);
            var order = new Order
            {
                Address = model.Address,
                TotalPrice = grandTotalPrice,
                PhoneNumber = model.PhoneNumber,
                OrderDate = model.OrderDate,
                Comment = model.Comment,
                PaymentMethod = paymentMethod,
                CartId = cartId,
                CustomerId = customerId
            };

            await context.Orders.AddAsync(order);
            await context.SaveChangesAsync();
            return order.Id;
        }
    }
}

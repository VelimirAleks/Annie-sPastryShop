using Annie_sPastryShop.Infrastructure.Data;
using AnniesPastryShop.Core.Contracts;
using AnniesPastryShop.Infrastructure.Data.Models;
using AnniesPastryShop.Infrastructure.Data.Models.Roles;
using Microsoft.EntityFrameworkCore;

namespace AnniesPastryShop.Core.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ApplicationDbContext context;

        public CustomerService(ApplicationDbContext _context)
        {
            context = _context;
        }

        public async Task<bool> CreateCartAsync(string userId)
        {
            var existingCustomer = await context.Customers.FirstOrDefaultAsync(c => c.UserId == userId);
            if (existingCustomer != null)
            {
                var existingCart = await context.Carts.FirstOrDefaultAsync(c => c.CustomerId == existingCustomer.Id);
                if (existingCart == null)
                {
                    Cart cart = new Cart
                    {
                        CustomerId = existingCustomer.Id,
                    };
                    await context.Carts.AddAsync(cart);
                    var result = await context.SaveChangesAsync();
                    return result > 0;
                }
            }
            return false;
        }

        public async Task<int> GetCartIdForCustomerAsync(string userId)
        {
            var cart = await context.Carts
                .Where(c => c.Customer.UserId == userId)
                .FirstOrDefaultAsync();
            return cart?.Id ?? 0;
        }

        public async Task<bool> IsUserCustomerAsync(string userId)
        {
            return await context.Customers.AnyAsync(c => c.UserId == userId);
        }

        public async Task<bool> SaveAdditionalDetailsAsync(string userId, string fullName)
        {
            var existingCustomer = await context.Customers.FirstOrDefaultAsync(c => c.UserId == userId);
            if (existingCustomer != null)
            {
                existingCustomer.FullName = fullName;
                context.Customers.Update(existingCustomer);
            }
            else
            {
                Customer customer = new Customer
                {
                    UserId = userId,
                    FullName = fullName,
                };
                await context.Customers.AddAsync(customer);
            }
            var result = await context.SaveChangesAsync();

            return result > 0;
        }
    }
}

using Annie_sPastryShop.Infrastructure.Data;
using AnniesPastryShop.Core.Contracts;
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

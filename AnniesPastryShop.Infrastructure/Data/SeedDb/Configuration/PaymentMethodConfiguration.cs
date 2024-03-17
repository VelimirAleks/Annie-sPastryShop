using AnniesPastryShop.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnniesPastryShop.Infrastructure.Data.SeedDb.Configuration
{
    internal class PaymentMethodConfiguration : IEntityTypeConfiguration<PaymentMethod>
    {
        public void Configure(EntityTypeBuilder<PaymentMethod> builder)
        {
            var data = new SeedData();

            builder.HasData(new PaymentMethod[]
            {
                data.Card,
                data.BankTransfer,
                data.PayPal,
                data.CashOnDelivery
            });
        }
    }
}

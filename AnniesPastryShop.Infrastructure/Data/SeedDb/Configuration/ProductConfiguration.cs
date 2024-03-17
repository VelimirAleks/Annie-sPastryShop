using AnniesPastryShop.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnniesPastryShop.Infrastructure.Data.SeedDb.Configuration
{
    internal class ProductConfiguration:IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            var data = new SeedData();

            builder.HasData(new Product[]
            {
                data.ChocolateCake, 
                data.RedVelvetCake,
                data.VanillaCake,
                data.LemonCake,
                data.ApplePie,
                data.BlueberryPie,
                data.CherryPie,
                data.PumpkinPie,
                data.MochaCupcake,
                data.StrawberryCupcake,
                data.BananaCupcake,
                data.PistachioCupcake
            });
        }
    }
}

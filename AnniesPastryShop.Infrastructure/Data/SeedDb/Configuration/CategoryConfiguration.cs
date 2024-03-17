using AnniesPastryShop.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnniesPastryShop.Infrastructure.Data.SeedDb.Configuration
{
    internal class CategoryConfiguration: IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            var data = new SeedData();

            builder.HasData(new Category[]
            { 
                data.Cakes,
                data.Pies,
                data.Cupcakes
            });
        }
    }
}

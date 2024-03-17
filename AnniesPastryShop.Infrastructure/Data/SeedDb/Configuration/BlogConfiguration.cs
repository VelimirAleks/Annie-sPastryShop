using AnniesPastryShop.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnniesPastryShop.Infrastructure.Data.SeedDb.Configuration
{
    internal class BlogConfiguration:IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            var data = new SeedData();

            builder.HasData(new Blog[]
            {
                data.SweetDelights,
                data.HolidaySpecials,
                data.CakeDecoratingTips,
                data.HealthyBites
            });
        }
    }
}

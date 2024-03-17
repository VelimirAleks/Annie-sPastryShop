using AnniesPastryShop.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnniesPastryShop.Infrastructure.Data.SeedDb.Configuration
{
    internal class ReviewConfiguration:IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            var data = new SeedData();

            var chocolateCakeReviews = data.ChocolateCakeReviews;
            var cherryPieReviews = data.CherryPieReviews;
            var mochaCupcakeReviews = data.MochaCupcakeReviews;

            var reviews = new List<Review>();

            reviews.AddRange(chocolateCakeReviews);
            reviews.AddRange(cherryPieReviews);
            reviews.AddRange(mochaCupcakeReviews);

            builder.HasData(reviews);
        }
    }
}

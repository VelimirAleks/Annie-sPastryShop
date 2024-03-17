using AnniesPastryShop.Infrastructure.Data.Models.Roles;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnniesPastryShop.Infrastructure.Data.SeedDb.Configuration
{
    internal class ModeratorConfiguration:IEntityTypeConfiguration<Moderator>
    {
        public void Configure(EntityTypeBuilder<Moderator> builder)
        {
            var data = new SeedData();

            builder.HasData(new Moderator[] { data.Moderator });
        }
    }
}

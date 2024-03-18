using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnniesPastryShop.Infrastructure.Data.SeedDb.Configuration
{
    internal class RoleConfiguration:IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            var data = new SeedData();

            builder.HasData(new IdentityRole[]
            {
                data.AdministratorRole,
                data.ModeratorRole
            });
        }
    }
}

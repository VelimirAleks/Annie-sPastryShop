using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnniesPastryShop.Infrastructure.Data.SeedDb.Configuration
{
    internal class UserConfiguration: IEntityTypeConfiguration<IdentityUser>
    {
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            var data = new SeedData();

            builder.HasData(new IdentityUser[]
            { 
                data.AdministratorUser,
                data.ModeratorUser,
                data.CustomerUser
            });
        }
    }
}

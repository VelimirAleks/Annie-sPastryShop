using AnniesPastryShop.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnniesPastryShop.Infrastructure.Data.SeedDb.Configuration
{
    internal class PictureConfiguration:IEntityTypeConfiguration<Picture>
    {
        public void Configure(EntityTypeBuilder<Picture> builder)
        {
            var data = new SeedData();

            var chocolateCakePictures=data.ChocolateCakePictures;
            var redVelvetCakePictures=data.RedVelvetCakePictures;
            var vanillaCakePictures=data.VanillaCakePictures;
            var lemonCakePictures=data.LemonCakePictures;
            var applePiePictures=data.ApplePiePictures;
            var blueberryPiePictures=data.BlueberryPiePictures;
            var cherryPiePictures=data.CherryPiePictures;
            var pumpkinPiePictures=data.PumpkinPiePictures;
            var mochaCupcakePictures=data.MochaCupcakePictures;
            var strawberryCupcakePictures=data.StrawberryCupcakePictures;
            var bananaCupcakePictures=data.BananaCupcakePictures;
            var pistachioCupcakePictures=data.PistachioCupcakePictures;

            var pictures = new List<Picture>();

            pictures.AddRange(chocolateCakePictures);
            pictures.AddRange(redVelvetCakePictures);
            pictures.AddRange(vanillaCakePictures);
            pictures.AddRange(lemonCakePictures);
            pictures.AddRange(applePiePictures);
            pictures.AddRange(blueberryPiePictures);
            pictures.AddRange(cherryPiePictures);
            pictures.AddRange(pumpkinPiePictures);
            pictures.AddRange(mochaCupcakePictures);
            pictures.AddRange(strawberryCupcakePictures);
            pictures.AddRange(bananaCupcakePictures);
            pictures.AddRange(pistachioCupcakePictures);

            builder.HasData(pictures);
        }
    }
}

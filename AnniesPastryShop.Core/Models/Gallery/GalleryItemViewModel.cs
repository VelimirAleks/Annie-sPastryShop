namespace AnniesPastryShop.Core.Models.Gallery
{
    public class GalleryItemViewModel
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public int ProductId { get; set; } 
    }
}

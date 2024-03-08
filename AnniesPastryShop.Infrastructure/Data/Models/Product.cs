using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnniesPastryShop.Infrastructure.Data.Models
{
    [Comment("Products table")]
    public class Product
    {
        [Key]
        [Comment("Product identifier")]
        public int Id { get; set; }

        [Comment("Product name")]
        [Required]
        public string Name { get; set; }=string.Empty;

        [Comment("Product price")]
        [Required]
        public decimal Price { get; set; }

        [Comment("Product description")]
        [Required]
        public string Description { get; set; } = string.Empty;

        [Comment("Product image")]
        [Required]
        public string ImageUrl { get; set; } = string.Empty;

        [Comment("Product category")]
        [Required]
        public int CategoryId { get; set; }

        [Comment("Product category")]
        [Required]
        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;
    }
}

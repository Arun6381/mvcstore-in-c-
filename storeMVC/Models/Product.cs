using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace storeMVC.Models
{
    public class Product
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; } = "";
        [MaxLength(100)]
        public string Brand { get; set; } = "";
        [MaxLength(100)]
        public string Category { get; set; } = "";

        public string Description { get; set; } = "";
        [Precision(16, 2)]
        public string Price { get; set; }
        [MaxLength(100)]
        public string ImageFileName { get; set; } = "";
        public DateTime CreateAt { get; set; }

    }
}

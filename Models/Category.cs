using System.ComponentModel.DataAnnotations;

namespace HoangVu_5292.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required, StringLength(50)]
        public required string Name { get; set; }
        public required List<Product> Products
        {
            get; set;
        }
    }
}

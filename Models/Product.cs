﻿using System.ComponentModel.DataAnnotations;

namespace HoangVu_5292.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required, StringLength(100)]
        public required string Name { get; set; }

        public Product(string name)
        {
            Name = name;
        }

        [Range(0.01, 10000.00)]
        public decimal Price { get; set; }
        public required string Description { get; set; }
        public string? ImageUrl { get; set; }
        public List<ProductImage>? Images { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}

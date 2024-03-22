namespace HoangVu_5292.Models
{
    public class ProductImage
    {
        public required int Id { get; set; }
        public required string Url { get; set; }

        public ProductImage(string url)
        {
            Url = url;
        }

        public required int ProductId { get; set; }
        public required Product? Product { get; set; }
    }
}

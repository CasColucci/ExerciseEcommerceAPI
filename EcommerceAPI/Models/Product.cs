namespace EcommerceAPI.Models
{
    public class Product
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public required string Description { get; set; }

        public decimal Price { get; set; }

        public Category Category { get; set; }

        public  DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }
    }

    public enum Category
    {
        Electronics,
        Clothing,
        Home,
        Kitchen,
        Beauty
    }
}

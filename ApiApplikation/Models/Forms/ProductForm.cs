namespace ApiApplikation.Models.Forms
{
    public class ProductForm
    {
        internal readonly int CategoryId;

        public string Name { get; set; } = null!;

        public decimal Price { get; set; }
        public string CategoryName { get; set; } = null!;
    }
}

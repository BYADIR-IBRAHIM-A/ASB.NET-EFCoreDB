namespace dbTable.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public required string Description { get; set; }
        public required string Name { get; set; }
        public float Price { get; set; }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace dbTable.Models
{
    public class Manufacturer : Controller
    {
            public int Id { get; set; }
            public required string Location { get; set; }
            public required string Name { get; set; }
            public required List<ProductModel> Products { get; set; } = new List<ProductModel>();

    }
}

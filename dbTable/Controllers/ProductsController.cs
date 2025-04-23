using System;
using Microsoft.AspNetCore.Mvc;
using dbTable.Data;


namespace dbTable.Controllers
{
    public class ProductsController : Controller
    {
        // This is the database context that will be used to access the database
        private readonly AppDbContext _db;

        public ProductsController(AppDbContext db)
        {
            _db = db;
        }
        // GET: /products
        public IActionResult Index()
        {
            if (_db == null || _db.Products == null)
                return NotFound();

            var products = _db.Products.ToList();
            return View(products);
        }
    }
}

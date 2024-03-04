using Lesson8Task_.Data;
using Lesson8Task_.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lesson8Task_.Controllers
{
    public class ProductController : Controller
    {
        DbSet<Category> categories1;
        private readonly AppDbContext _appDbContext;

        public ProductController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            categories1 = _appDbContext.Categories;
        }


        public IActionResult Index()
        {
            var products = _appDbContext.Products.Include(p => p.Category).ToList();
            return View(products);
        }


        public IActionResult Add()
        {
            var categories = _appDbContext.Categories.ToList();
           
            ViewData["Categories"] = categories;
           
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Add(AddProductViewModel product)
        {
            if (ModelState.IsValid)
            {
                //var newProduct = new Product
                //{
                //    Category = product.Category,
                //    Price = product.Price,
                //    Description = product.Description,
                //    ImageUrl = product.ImageUrl,
                //    Title = product.Title,
                //};
                //_appDbContext.Products.Add(newProduct);
                //_appDbContext.Products.Add(product);


               

                var newProduct = new Product
                {
                    CategoryId = product.CategoryId,
                    Price = product.Price,
                    Description = product.Description,
                    ImageUrl = product.ImageUrl,
                    Title = product.Title,
                   
                };
                _appDbContext.Products.Add(newProduct);
                await _appDbContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(product);
        }


     

    }
}

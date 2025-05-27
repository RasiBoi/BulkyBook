using Bulkybook.Data;
using Bulkybook.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bulkybook.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Category> objCategory = _db.Categories; // Assuming Categories is a DbSet<Category>
            return View(objCategory);
        }
    }
}

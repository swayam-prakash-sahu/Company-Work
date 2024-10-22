using Microsoft.AspNetCore.Mvc;
using Mvcapp2.Data;
using Mvcapp2.Models;

namespace Mvcapp2.Controllers
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
            List <Category> obCategorylist = _db.Categories.ToList();
            return View(obCategorylist);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}

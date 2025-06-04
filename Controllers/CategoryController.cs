using Microsoft.AspNetCore.Mvc;
using mvcproject.Models;
using Microsoft.EntityFrameworkCore;

namespace mvcproject.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var categories = _context.Categories.ToList();
            return View("~/Views/panel/category/index.cshtml", categories);
        }
        
        public IActionResult Create()
        {
            return View("~/Views/panel/category/create.cshtml");
        }
       

        [HttpPost]
        public IActionResult Store(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return RedirectToAction("Index", "Category");
        }

        public IActionResult Show(int id)
        {
            var category = _context.Categories.FirstOrDefault(c => c.Id == id);
            return View("panel/category/show", category);
        }

        public IActionResult Edit(int id)
        {
            var category = _context.Categories.Find(id);
            return View("~/Views/panel/category/edit.cshtml", category);
        }

        [HttpPost]
        public IActionResult Update(Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
            return RedirectToAction("Index", "Category");
        }

        public IActionResult Destroy(int id)
        {
            var category = _context.Categories.Find(id);
            if (category != null)
            {
                _context.Categories.Remove(category);
                _context.SaveChanges();
            }

            return Redirect(Request.Headers["Referer"].ToString());
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var category = _context.Categories.Find(id);
            if (category != null)
            {
                _context.Categories.Remove(category);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using mvcproject.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;


namespace mvcproject.Controllers
{
    public class ArticleController : Controller
    {
        private readonly AppDbContext _context;

        public ArticleController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var articles = _context.Articles.ToList();
            return View("~/Views/panel/article/index.cshtml", articles);
        }
        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(_context.Categories.ToList(), "Id", "Name");
            return View("~/Views/panel/article/create.cshtml");
        }

        [HttpPost]
        public IActionResult Store(Article article)
        {
            _context.Articles.Add(article);
            _context.SaveChanges();
            return RedirectToAction("Index", "Article");
        }

        public IActionResult Show(int id)
        {
            var article = _context.Articles.FirstOrDefault(a => a.Id == id);
            return View("panel/article/show", article);
        }

        public IActionResult Edit(int id)
        {
            var article = _context.Articles.FirstOrDefault(a => a.Id == id);
            ViewBag.Categories = _context.Categories
                .Select(c => new SelectListItem
                {
                    Value = c.Id.ToString(),
                    Text = c.Name
                }).ToList();

            ViewData["article"] = article;
            return View("~/Views/panel/article/edit.cshtml");
        }
        [HttpPost]
        public IActionResult Update(int id, Article updatedArticle)
        {
            var article = _context.Articles.FirstOrDefault(a => a.Id == id);
            if (article != null)
            {
                article.Title = updatedArticle.Title;
                article.Body = updatedArticle.Body;
                article.CategoryId = updatedArticle.CategoryId;
                _context.SaveChanges();
            }

            return RedirectToAction("Index", "Article");
        }

        public IActionResult Destroy(int id)
        {
            var article = _context.Articles.FirstOrDefault(a => a.Id == id);
            if (article != null)
            {
                _context.Articles.Remove(article);
                _context.SaveChanges();
            }

            return Redirect(Request.Headers["Referer"].ToString());
        }
    }
}
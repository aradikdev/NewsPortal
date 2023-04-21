using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewsPortal.Data;
using NewsPortal.Models;
using System.Diagnostics;

namespace NewsPortal.Controllers
{
    public class HomeController : Controller
    {
        private readonly NewsPortalDbContext _db;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, NewsPortalDbContext context)
        {
            _logger = logger;
            _db = context;
        }

        public IActionResult Index()
        {
            ViewBag.Categories = _db.Categories.ToList();
            ViewBag.Articles = _db.Articles.ToList();
            return View();
        }

        public IActionResult Category(int id)
        {
            Category category = _db.Categories
                .FirstOrDefault(c => c.Id == id);
            ViewBag.Articles = _db.Articles
                .Where(c => c.CategoryId == id)
                .ToList();
            return View(category);
        }
        public IActionResult Article(int id)
        {
            Article article = _db.Articles
                .FirstOrDefault(c => c.Id == id);
            return View(article);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
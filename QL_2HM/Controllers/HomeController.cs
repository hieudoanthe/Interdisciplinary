using QL_2HM.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace forestry_law.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var products = _context.Products.ToList();
            return View(products);
        }

        // Add other actions...
    }
}

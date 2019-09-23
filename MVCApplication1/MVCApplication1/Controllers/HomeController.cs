using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MVCApplication1.Data;
using MVCApplication1.Models;

namespace MVCApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
       public HomeController( ApplicationDbContext context )
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View( _context.Songs.Where( m => m.IsFeatured ).ToList());
    }
        public IActionResult Songs()
        {
            return View(_context.Songs.Where(m => m.IsActive).ToList());
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
        public IActionResult Albums()
        {
            return View(_context.Songs.GroupBy(x => x.Album).Select(grp => grp.First()).ToString());
        }

    }
}

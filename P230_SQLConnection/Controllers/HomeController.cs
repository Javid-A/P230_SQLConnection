using Microsoft.AspNetCore.Mvc;
using P230_SQLConnection.DAL;
using P230_SQLConnection.Entities;
using System.Collections.Generic;

namespace P230_SQLConnection.Controllers
{
    public class HomeController:Controller
    {
        readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Slider> sliders = _context.Sliders.ToList();
            return View(sliders);
        }
    }
}

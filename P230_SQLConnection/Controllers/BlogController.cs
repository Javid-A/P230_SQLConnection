using Microsoft.AspNetCore.Mvc;
using P230_SQLConnection.DAL;

namespace P230_SQLConnection.Controllers
{
    public class BlogController:Controller
    {
        readonly ApplicationDbContext _context;

        public BlogController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

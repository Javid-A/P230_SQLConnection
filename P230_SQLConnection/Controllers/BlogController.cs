using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P230_SQLConnection.DAL;
using P230_SQLConnection.Entities;

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
            List<Blog> blogs = _context.Blogs.Include(b=>b.Category).ToList();
            return View(blogs);
        }
        public IActionResult Detail(int id)
        {
            if (id == 0) return NotFound();
            Blog? blog = _context.Blogs.Include(b=>b.Category)
                                            .Include(b=>b.BlogTags).ThenInclude(bt=>bt.Tag)
                                                .SingleOrDefault(b => b.Id == id);

            return View(blog);
        }
    }

}

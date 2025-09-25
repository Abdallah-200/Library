using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Library.Data;
using Library.Models;

namespace Library.Controllers
{
    public class BooksController : Controller
    {
        private readonly ApplicationDbContext _db;
        public BooksController(ApplicationDbContext db) => _db = db;

        public async Task<IActionResult> Index()
        {
            var books = await _db.Books.Include(b => b.Author).Include(b => b.Category).ToListAsync();
            return View(books);
        }
    }
}

using ExamOne.DataAccesLayer;
using ExamOne.ViewModels.Categories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExamOne.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController(SperingContext _context) : Controller
    {
        private readonly SperingContext _context = _context;

        public async Task<IActionResult> Index()
        {
            return View(await _context.Categories
                .Select(c => new GetCategoryVM
                {
                    Id = c.Id,
                    Name = c.Name,
                }).ToListAsync());
        }

       
    }
}

using ExamOne.DataAccesLayer;
using ExamOne.ViewModels.Categories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExamOne.Areas.Admin.Controllers;

[Area("Admin")]
public class CategoryController(SperingContext _context) : Controller
{
    private readonly SperingContext _context = _context;

    public async Task<IActionResult> Index()
    {
        return View(_context.Categories
            .Select(c => new GetCategoryAdminVM
            {
                Id = c.Id,
                Name = c.Name,
                CreatedTime = c.CreatedTime.ToString("dd MMM ddd"),
                UpdatedTime = c.UpdatedTime.Year > 1 ? c.UpdatedTime.ToString("dd MMM ddd yyyy") : ""

            }).ToListAsync());
    }

   
}

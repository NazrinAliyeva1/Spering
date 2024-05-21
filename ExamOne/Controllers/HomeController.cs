using ExamOne.DataAccesLayer;
using ExamOne.ViewModels.Categories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExamOne.Controllers
{
   
    public class HomeController(SperingContext _sql) : Controller
    {
        public async Task<IActionResult> Index()
        {

            var categories = await _sql.Categories
                .Select(x => new GetCategoryVM
                {
                    Id = x.Id,
                    Name = x.Name,
                }).ToListAsync();
            return View(categories);
        }



    }
}

using Front_To_Back_Project.Data;
using Front_To_Back_Project.Models.Home;
using Microsoft.AspNetCore.Mvc;

namespace Front_To_Back_Project.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {

        var recentWorks = _context.RecentWorks.ToList();

        var recentWorksList = new List<RecentWorkVM>();
        foreach (var recentWork in recentWorks) 
        {
            var recentWorkVM = new RecentWorkVM
            {
                PhotoPath = recentWork.PhotoPath,
                Title = recentWork.Title,
                Description = recentWork.Description
            };

            recentWorksList.Add(recentWorkVM);
        }

        var model = new HomeIndexVM
        {
            RecentWorks = recentWorksList
        };

        return View(model);
    }
}

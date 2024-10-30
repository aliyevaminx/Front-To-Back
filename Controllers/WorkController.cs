using Microsoft.AspNetCore.Mvc;

namespace Front_To_Back_Project.Controllers;

public class WorkController : Controller
{
    public IActionResult Index() {  return View(); }
    public IActionResult Details() { return View(); }
}

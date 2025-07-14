using Microsoft.AspNetCore.Mvc;

namespace MVC_ModelBinding_Jellyfin_Clone.Controllers;

public class LibraryController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
}

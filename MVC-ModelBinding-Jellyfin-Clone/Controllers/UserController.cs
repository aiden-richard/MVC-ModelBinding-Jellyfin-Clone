using Microsoft.AspNetCore.Mvc;

namespace MVC_ModelBinding_Jellyfin_Clone.Controllers;

public class UserController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Create()
    {
        return View();
    }
}

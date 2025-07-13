using Microsoft.AspNetCore.Mvc;
using MVC_ModelBinding_Jellyfin_Clone.Models;

namespace MVC_ModelBinding_Jellyfin_Clone.Controllers;

public class UserController : Controller
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

    [HttpPost]
    public IActionResult Create(CreateUserViewModel new_user)
    {
        if (ModelState.IsValid)
        {
            // Add the user to the database

            // Redirect to the Users page
            return RedirectToAction("Index");
        }

        return View(new_user);
    }
}

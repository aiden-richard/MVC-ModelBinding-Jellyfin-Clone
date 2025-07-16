using Microsoft.AspNetCore.Mvc;
using MVC_ModelBinding_Jellyfin_Clone.Models;

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

    [HttpPost]
    public IActionResult Create(Library new_library)
    {
        if (ModelState.IsValid)
        {   
            TempData["Message"] = "Library created successfully!";

            // Add the library to the database

            // Redirect to the Libraries page
            return RedirectToAction("Index");
        }
        return View(new_library);
    }
}

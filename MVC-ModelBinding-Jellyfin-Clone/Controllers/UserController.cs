using Microsoft.AspNetCore.Mvc;
using MVC_ModelBinding_Jellyfin_Clone.Models;
using MVC_ModelBinding_Jellyfin_Clone.Services;

namespace MVC_ModelBinding_Jellyfin_Clone.Controllers;

public class UserController(PasswordService passwordService) : Controller
{
    private readonly PasswordService PasswordService = passwordService;

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
            // Hash the password
            PasswordService.CreatePasswordHash(new_user.Password, out byte[] passwordHash, out byte[] passwordSalt);
            
            User user = new(new_user.Username, passwordHash, passwordSalt, new_user.Role, new_user.PreferredLanguage);

            // Add the user to the database

            // Redirect to the Users page
            return RedirectToAction("Index");
        }

        return View(new_user);
    }
}

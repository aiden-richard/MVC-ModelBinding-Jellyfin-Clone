using System.ComponentModel.DataAnnotations;

namespace MVC_ModelBinding_Jellyfin_Clone.Models;

/// <summary>
/// This class is used to create a new user
/// It is needed so the Controller can take the
/// password and Hash it before making a new User
/// with the hashed password and salt
/// </summary>
/// <remarks>
/// Some properties are duplicated from the User model.
/// Ideally, this would be avoided by being DRY (Don't Repeat Yourself).
/// </remarks>
public class CreateUserViewModel
{
    /// <summary>
    /// The user's username, stored as a string
    /// Valid characters are A-Z, a-z, 0-9, and underscores
    /// </summary>
    [StringLength(50, MinimumLength = 1, ErrorMessage = "Username must not be longer than 50 characters")]
    [RegularExpression(@"^[a-zA-Z0-9_]+$", ErrorMessage = "Username can only contain letters, numbers, and underscores")]
    [Required(ErrorMessage = "Username is required")]
    public required string Username { get; set; }

    /// <summary>
    /// The user's password, stored as a string
    /// but will be hashed in the Create method of the UserController
    /// </summary>
    [StringLength(100, MinimumLength = 1, ErrorMessage = "Password must not be longer than 100 characters")]
    [Required(ErrorMessage = "Password is required")]
    [DataType(DataType.Password)]
    public required string Password { get; set; }

    /// <summary>
    /// Role of the user, stored as a string
    /// This can be "Admin" or "User"
    /// </summary>
    /// <remarks>
    /// If more work is put into this project, consider using ASP.NET Identity for built-in role and claim management.
    /// </remarks>
    [RegularExpression(@"^(Admin|User)$", ErrorMessage = "Role must be either 'Admin' or 'User'")]
    [Required(ErrorMessage = "Role is required")]
    public required string Role { get; set; }

    /// <summary>
    /// Preferred language for the user, stored as a string
    /// </summary>
    [Required(ErrorMessage = "Preferred language is required")]
    [StringLength(50, ErrorMessage = "Language name can't be longer than 50 characters")]
    public required string PreferredLanguage { get; set; }
}

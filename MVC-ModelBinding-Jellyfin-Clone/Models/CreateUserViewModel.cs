using MVC_ModelBinding_Jellyfin_Clone.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace MVC_ModelBinding_Jellyfin_Clone.Models;

/// <summary>
/// This class is used to create a new user
/// It is needed so the Controller can take the
/// password and Hash it before making a new User
/// </summary>
public class CreateUserViewModel : UserBase
{
    /// <summary>
    /// The user's password, stored as a string
    /// but will be hashed before being saved
    /// This happpens in the Create method of the UserController
    /// </summary>
    [StringLength(128, MinimumLength = 3, ErrorMessage = "Password must be between 3 and 128 characters")]
    [Required(ErrorMessage = "Password is required")]
    [DataType(DataType.Password)]
    public required string Password { get; set; }
}

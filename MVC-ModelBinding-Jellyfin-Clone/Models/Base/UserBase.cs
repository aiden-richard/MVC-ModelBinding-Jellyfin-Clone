using System.ComponentModel.DataAnnotations;

namespace MVC_ModelBinding_Jellyfin_Clone.Models.Base;

/// <summary>
/// This class is used as a base for user-related models
/// </summary>
public abstract class UserBase
{
    /// <summary>
    /// The user's username, stored as a string
    /// Valid characters are A-Z, a-z, 0-9, and underscores
    /// </summary>
    [StringLength(50, MinimumLength = 1, ErrorMessage = "Username must not be longer than 50 characters")]
    [RegularExpression(@"^[a-zA-Z0-9_]+$", ErrorMessage = "Username can only contain letters, numbers, and underscores")]
    [Required(ErrorMessage = "Username is required")]
    public string Username { get; set; } = string.Empty;

    /// <summary>
    /// Defines the available roles for the user
    /// </summary>
    public enum RolesEnum
    {
        Admin,
        User
    }

    /// <summary>
    /// Indicates the role of the user
    /// </summary>
    [Required(ErrorMessage = "A role is required")]
    [EnumDataType(typeof(RolesEnum), ErrorMessage = "Role must be one of (\"Admin\", \"User\")")]
    public RolesEnum Role { get; set; } = RolesEnum.User;

    /// <summary>
    /// Defines the available languages for the user
    /// </summary>
    public enum  PreferredLanguageEnum
    {
        English
    }

    /// <summary>
    /// Indicates the preferred language of the user
    /// </summary>
    [Required(ErrorMessage = "Preferred language is required")]
    [EnumDataType(typeof(PreferredLanguageEnum), ErrorMessage = "Preferred Language must be one of (\"English\")")]
    public PreferredLanguageEnum PreferredLanguage { get; set; } = PreferredLanguageEnum.English;
}

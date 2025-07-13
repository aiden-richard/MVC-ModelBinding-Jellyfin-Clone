using System.ComponentModel.DataAnnotations;

namespace MVC_ModelBinding_Jellyfin_Clone.Models;

/// <summary>
/// Represents a user in the jellyfin server
/// </summary>
public class User
{
    public User(string _Username, byte[] _PasswordHash, byte[] _PasswordSalt, string _PrefferedLanguage)
    {
        Username = _Username;
        PasswordHash = _PasswordHash;
        PasswordSalt = _PasswordSalt;
        PreferredLanguage = _PrefferedLanguage;
    }

    /// <summary>
    /// A unique int32 identifier for the user
    /// This is the user's primary key in the database
    /// Should be set by the database
    /// </summary>
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// The user's username, stored as a string
    /// Valid characters are A-Z, a-z, 0-9, and underscores
    /// </summary>
    [StringLength(50, MinimumLength = 1)]
    [RegularExpression(@"^[a-zA-Z0-9_]+$", ErrorMessage = "Username can only contain letters, numbers, and underscores")]
    [Required(ErrorMessage = "Username is required")]
    public required string Username { get; set; }

    /// <summary>
    /// The user's password hash, stored as a byte array
    /// </summary>
    public byte[] PasswordHash { get; set; }

    /// <summary>
    /// The user's password salt, stored as a byte array
    /// </summary>
    public byte[] PasswordSalt { get; set; }

    /// <summary>
    /// Role of the user, stored as a string
    /// This can be "Admin" or "User"
    /// </summary>
    /// <remarks>
    /// If more work is put into this project, consider using ASP.NET Identity for built-in role and claim management.
    /// </remarks>
    [Required(ErrorMessage = "Role is required")]
    [RegularExpression(@"^(Admin|User)$", ErrorMessage = "Role must be either 'Admin' or 'User'")]
    public string Role { get; set; } = "User";

    /// <summary>
    /// Preffered language for the user, stored as a string
    /// </summary>
    [Required(ErrorMessage = "Preferred language is required")]
    [StringLength(50, ErrorMessage = "Language name can't be longer than 50 characters")]
    public required string PreferredLanguage { get; set; } = "English";
}

using System.ComponentModel.DataAnnotations;

namespace MVC_ModelBinding_Jellyfin_Clone.Models;

/// <summary>
/// Represents a user in the jellyfin server
/// </summary>
public class User(string username, byte[] passwordHash, byte[] passwordSalt, string role, string preferredLanguage)
{
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
    public string Username { get; set; } = username;

    /// <summary>
    /// The user's password hash, stored as a byte array
    /// </summary>
    public byte[] PasswordHash { get; set; } = passwordHash;

    /// <summary>
    /// The user's password salt, stored as a byte array
    /// </summary>
    public byte[] PasswordSalt { get; set; } = passwordSalt;

    /// <summary>
    /// Role of the user, stored as a string
    /// This can be "Admin" or "User"
    /// </summary>
    /// <remarks>
    /// If more work is put into this project, consider using ASP.NET Identity for built-in role and claim management.
    /// </remarks>
    public string Role { get; set; } = role;

    /// <summary>
    /// Preffered language for the user, stored as a string
    /// </summary>
    public string PreferredLanguage { get; set; } = preferredLanguage;
}

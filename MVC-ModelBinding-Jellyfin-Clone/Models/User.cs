using MVC_ModelBinding_Jellyfin_Clone.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace MVC_ModelBinding_Jellyfin_Clone.Models;

/// <summary>
/// Represents a user in the jellyfin server
/// </summary>
public class User : UserBase
{
    public User(string username, byte[] passwordHash, byte[] passwordSalt, RolesEnum role, PreferredLanguageEnum preferredLanguage)
    {
        Username = username;
        PasswordHash = passwordHash;
        PasswordSalt = passwordSalt;
        Role = role;
        PreferredLanguage = preferredLanguage;
    }

    /// <summary>
    /// A unique int32 identifier for the user
    /// This is the user's primary key in the database
    /// Should be set by the database
    /// </summary>
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// The user's password hash, stored as a byte array
    /// </summary>
    public byte[] PasswordHash { get; set; }

    /// <summary>
    /// The user's password salt, stored as a byte array
    /// </summary>
    public byte[] PasswordSalt { get; set; }
}

using System.ComponentModel.DataAnnotations;

namespace MVC_ModelBinding_Jellyfin_Clone.Models;

/// <summary>
/// This class represents a library in the jellyfin server
/// Includes metadata such as display name, content type, and storage directory.
/// </summary>
public class Library
{
    /// <summary>
    /// A unique int32 identifier for the library
    /// This is the library's primary key in the database
    /// Should be set by the database
    /// </summary>
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// Defines the available content types for the library
    /// </summary>
    public enum ContentTypeEnum
    {
        Movies,
        Music,
        Books,
        Shows
    }

    /// <summary>
    /// Indicates the selected content type for the library
    /// </summary>
    [Required(ErrorMessage = "A content type is required")]
    [EnumDataType(typeof(ContentTypeEnum)
        , ErrorMessage = "Content Type Must be one of (\"Movies\", \"Music\", \"Books\", and \"Shows\")")]
    public ContentTypeEnum ContentType { get; set; }

    /// <summary>
    /// The name of the library, stored as a string
    /// Valid characters are A-Z, a-z, 0-9, and underscores
    /// </summary>
    [StringLength(50, MinimumLength = 1, ErrorMessage = "Library name must not be longer than 50 characters")]
    [RegularExpression(@"^[a-zA-Z0-9_]+$", ErrorMessage = "Library name can only contain letters, numbers, and underscores")]
    [Required(ErrorMessage = "A display name is required")]
    public required string DisplayName { get; set; }

    /// <summary>
    /// The directory where the library is stored, stored as a string
    /// The regex follows slightly stricter rules than the ones found at this link
    /// https://www.cyberciti.biz/faq/linuxunix-rules-for-naming-file-and-directory-names/
    /// Here, we allow only letters, numbers, dashes, and slashes.
    /// The directory must also start with a slash
    /// </summary>
    /// <remarks>
    /// This directory should only be used in a read-only context
    /// it will pull any available media from the directory
    /// </remarks>
    [StringLength(255, MinimumLength = 1, ErrorMessage = "Directory must not be longer than 255 characters")]
    [RegularExpression(@"^\/[a-zA-Z0-9_\-/]*$"
        , ErrorMessage = "Directory must start with '/' and contain only letters, numbers, dashes, and slashes.")]
    [Required(ErrorMessage = "A directory is required")]
    public required string Directory { get; set; }
}

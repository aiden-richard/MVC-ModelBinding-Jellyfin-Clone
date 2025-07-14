namespace MVC_ModelBinding_Jellyfin_Clone.Services;

/// <summary>
/// This service is used to create a password hash and salt
/// </summary>
public class PasswordService
{
    /// <summary>
    /// This method creates a password hash and salt
    /// and stores them in the provided byte arrays.
    /// </summary>
    /// <param name="password">The user's plaintext password</param>
    /// <param name="passwordHash">The byte array that will hold the hash</param>
    /// <param name="passwordSalt">The byte array that will hold the salt</param>
    /// <exception cref="ArgumentNullException"></exception>
    public void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
    {
        if (string.IsNullOrEmpty(password))
        {
            throw new ArgumentNullException(nameof(password), "Password cannot be null or empty");
        }

        using var hmac = new System.Security.Cryptography.HMACSHA512();
        passwordSalt = hmac.Key;
        passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
    }
}

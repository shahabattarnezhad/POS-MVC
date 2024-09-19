using Microsoft.AspNetCore.Identity;

namespace Domain.Entities.Auth;

public class ApplicationUser : IdentityUser
{
    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? ProfileImageUrl { get; set; }


    public ICollection<Sale>? Sales { get; set; }
}

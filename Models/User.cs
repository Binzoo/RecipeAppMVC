using Microsoft.AspNetCore.Identity;

namespace RecipeApp;

public class ApplicationUser : IdentityUser
{
    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public List<Recipe>? Recipes { get; set; }
}

namespace RecipeApp;

public class Recipe
{
    public int RecipeId { get; set; }
    public string? RecipeTitle { get; set; }
    public string? RecipeDescription { get; set; }
    public string? RecipeSteps { get; set; }
    public string? RecipeImage { get; set; }
    public int ApplicationUserId { get; set; }
    public ApplicationUser ApplicationUser { get; set; }
}

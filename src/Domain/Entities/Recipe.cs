namespace EpicureanVault.Domain.Entities;

public class Recipe : BaseAuditableEntity
{
    public required string Name { get; set; }

    public string? Description { get; set; }

    public int Servings { get; set; } = 1;

    public TimeSpan PreperationTime { get; set; }

    public TimeSpan CookingTime { get; set; }

    public IEnumerable<Ingredient> Ingredients { get; set; } = [];

    public IEnumerable<Step> Steps { get; set; } = [];
}

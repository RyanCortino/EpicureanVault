namespace EpicureanVault.Domain.Entities;

public class Ingredient : BaseEntity
{
    public required string Name { get; set; }

    public required Quantity Quantity { get; set; }
}

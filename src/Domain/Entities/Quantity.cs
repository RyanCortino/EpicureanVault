namespace EpicureanVault.Domain.Entities;

public class Quantity : BaseEntity
{
    public required decimal Amount { get; set; }

    public required UnitOfMeasure UnitOfMeasure { get; set; }
}

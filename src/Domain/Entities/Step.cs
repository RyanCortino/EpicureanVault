namespace EpicureanVault.Domain.Entities;

public class Step : BaseEntity
{
    public int Index { get; set; }

    public string? Description { get; set; }

    public TimeSpan Duration { get; set; }
}

namespace EpicureanVault.Domain.Exceptions;

public class UnsupportedUnitOfMeasureException : Exception
{
    public UnsupportedUnitOfMeasureException(string code)
        : base($"Unit \"{code}\" is unsupported.") { }
}

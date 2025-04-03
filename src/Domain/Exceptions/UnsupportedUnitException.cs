namespace EpicureanVault.Domain.Exceptions;

public class UnsupportedUnitException : Exception
{
    public UnsupportedUnitException(string code)
        : base($"Unit \"{code}\" is unsupported.")
    {
    }
}

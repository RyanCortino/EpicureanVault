namespace EpicureanVault.Domain.UnitTests.ValueObjects;

using EpicureanVault.Domain.Exceptions;
using EpicureanVault.Domain.ValueObjects;
using FluentAssertions;
using NUnit.Framework;

public class UnitOfMeasureTests
{
    [Test]
    public void ShouldReturnCorrectUomCode()
    {
        var code = "G";

        var uom = UnitOfMeasure.From(code);

        uom.Code.Should().Be(code);
    }

    [Test]
    public void ToStringReturnsCode()
    {
        var uom = UnitOfMeasure.Gram;

        uom.ToString().Should().Be(uom.Code);
    }

    [Test]
    public void ShouldPerformImplicitConversionToUomCodeString()
    {
        string code = UnitOfMeasure.Milliliter;

        code.Should().Be("ML");
    }

    [Test]
    public void ShouldPerformExplicitConversionGivenSupportedUomCode()
    {
        var uom = (UnitOfMeasure)"KM";

        uom.Should().Be(UnitOfMeasure.Kilometer);
    }

    [Test]
    public void ShouldThrowUnsupportedColourExceptionGivenNotSupportedUomCode()
    {
        FluentActions
            .Invoking(() => UnitOfMeasure.From("RawInvestiture"))
            .Should()
            .Throw<UnsupportedUnitOfMeasureException>();
    }
}

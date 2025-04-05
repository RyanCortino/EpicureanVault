namespace EpicureanVault.Domain.ValueObjects;

public class UnitOfMeasure(string code) : ValueObject
{
    public static UnitOfMeasure From(string code)
    {
        var unit = new UnitOfMeasure(code);

        if (!SupportedUnits.Contains(unit))
        {
            throw new UnsupportedUnitOfMeasureException(code);
        }

        return unit;
    }

    // Mass - Metric
    public static UnitOfMeasure Milligram => new("MG");
    public static UnitOfMeasure Gram => new("G");
    public static UnitOfMeasure Kilogram => new("KG");
    public static UnitOfMeasure MetricTon => new("T");

    // Mass - Imperial
    public static UnitOfMeasure Ounce => new("OZ");
    public static UnitOfMeasure Pound => new("LB");
    public static UnitOfMeasure Stone => new("ST");
    public static UnitOfMeasure Ton => new("TON");

    // Volume - Metric
    public static UnitOfMeasure Milliliter => new("ML");
    public static UnitOfMeasure Liter => new("L");
    public static UnitOfMeasure CubicCentimeter => new("CM3");
    public static UnitOfMeasure CubicMeter => new("M3");

    // Volume - Imperial
    public static UnitOfMeasure Teaspoon => new("TSP");
    public static UnitOfMeasure Tablespoon => new("TBSP");
    public static UnitOfMeasure Quart => new("QT");
    public static UnitOfMeasure Pint => new("PT");
    public static UnitOfMeasure Cup => new("C");
    public static UnitOfMeasure FluidOunce => new("FL OZ");
    public static UnitOfMeasure Gallon => new("GAL");

    // Length - Metric
    public static UnitOfMeasure Millimeter => new("MM");
    public static UnitOfMeasure Centimeter => new("CM");
    public static UnitOfMeasure Meter => new("M");
    public static UnitOfMeasure Kilometer => new("KM");

    // Length - Imperial
    public static UnitOfMeasure Inch => new("IN");
    public static UnitOfMeasure Foot => new("FT");
    public static UnitOfMeasure Yard => new("YD");
    public static UnitOfMeasure Mile => new("MI");

    // Temperature - Metric
    public static UnitOfMeasure Celcius => new("°C");

    // Temperature - Imperial
    public static UnitOfMeasure Fahrenheit => new("°F");

    public string Code { get; private set; } = string.IsNullOrWhiteSpace(code) ? "Units" : code;

    public static implicit operator string(UnitOfMeasure unit)
    {
        return unit.ToString();
    }

    public static explicit operator UnitOfMeasure(string code)
    {
        return From(code);
    }

    public override string ToString()
    {
        return Code;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Code;
    }

    protected static IEnumerable<UnitOfMeasure> SupportedUnits
    {
        get
        {
            yield return Milligram;
            yield return Gram;
            yield return Kilogram;
            yield return MetricTon;
            yield return Milliliter;
            yield return Liter;
            yield return CubicCentimeter;
            yield return CubicMeter;
            yield return Millimeter;
            yield return Centimeter;
            yield return Meter;
            yield return Kilometer;
            yield return Celcius;

            yield return Ounce;
            yield return Pound;
            yield return Stone;
            yield return Ton;
            yield return Teaspoon;
            yield return Tablespoon;
            yield return Quart;
            yield return Pint;
            yield return Cup;
            yield return FluidOunce;
            yield return Gallon;
            yield return Inch;
            yield return Foot;
            yield return Yard;
            yield return Mile;
            yield return Fahrenheit;
        }
    }
}

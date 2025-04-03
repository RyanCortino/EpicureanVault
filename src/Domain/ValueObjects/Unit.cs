namespace EpicureanVault.Domain.ValueObjects;

public class Unit(string code) : ValueObject
{
    public static Unit From(string code)
    {
        var unit = new Unit(code);

        if (!SupportedUnits.Contains(unit))
        {
            throw new UnsupportedUnitException(code);
        }

        return unit;
    }

    // Undefined
    public static Unit Units => new("U");

    // Mass - Metric
    public static Unit Milligram => new("MG");
    public static Unit Gram => new("G");
    public static Unit Kilogram => new("KG");
    public static Unit MetricTon => new("T");

    // Mass - Imperial
    public static Unit Ounce => new("OZ");
    public static Unit Pound => new("LB");
    public static Unit Stone => new("ST");
    public static Unit Ton => new("TON");

    // Volume - Metric
    public static Unit Milliliter => new("ML");
    public static Unit Liter => new("L");
    public static Unit CubicCentimeter => new("CM3");
    public static Unit CubicMeter => new("M3");

    // Volume - Imperial
    public static Unit Teaspoon => new("TSP");
    public static Unit Tablespoon => new("TBSP");
    public static Unit Quart => new("QT");
    public static Unit Pint => new("PT");
    public static Unit Cup => new("C");
    public static Unit FluidOunce => new("FL OZ");
    public static Unit Gallon => new("GAL");

    // Length - Metric
    public static Unit Millimeter => new("MM");
    public static Unit Centimeter => new("CM");
    public static Unit Meter => new("M");
    public static Unit Kilometer => new("KM");

    // Length - Imperial
    public static Unit Inch => new("IN");
    public static Unit Foot => new("FT");
    public static Unit Yard => new("YD");
    public static Unit Mile => new("MI");

    // Temperature - Metric
    public static Unit Celcius => new("°C");

    // Temperature - Imperial
    public static Unit Fahrenheit => new("°F");

    public string Code { get; private set; } = string.IsNullOrWhiteSpace(code) ? "Undefined" : code;

    public static implicit operator string(Unit unit)
    {
        return unit.ToString();
    }

    public static explicit operator Unit(string code)
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

    protected static IEnumerable<Unit> SupportedUnits
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
            yield return Foot;
            yield return Mile;
            yield return Fahrenheit;
        }
    }
}

class UnitConverter
{
   

    public string GetDefaultUnit(string type)
    {
        switch (type.ToLower())
        {
            case "length": return "meters";
            case "weight": return "kilograms";
            case "temperature": return "celsius";
            default: throw new Exception("Invalid conversion type");
        }
    }
    public double Convert(double value,string fromUnit)
    {
        string type="";
        if (fromUnit == "meters" || fromUnit == "kilometers" || fromUnit == "miles" || fromUnit == "feet") type = "length";
        if (fromUnit == "grams" || fromUnit == "kilograms" || fromUnit == "pounds" || fromUnit == "ounces") type = "weight";
        if (fromUnit == "celsius" || fromUnit == "fahrenheit" || fromUnit == "kelvin") type = "temperature";

        string defaultUnit = GetDefaultUnit(type);
        return Convert(value,fromUnit,defaultUnit);
    }
    public double Convert(double value,string fromUnit,string toUnit)
    {
        fromUnit = fromUnit.ToLower();
        toUnit = toUnit.ToLower();
        if (fromUnit == toUnit) return value;

        // Length 
        if (fromUnit == "meters" && toUnit == "kilometers") return value * 0.001;
        if (fromUnit == "kilometers" && toUnit == "meters") return value * 1000;
        if (fromUnit == "miles" && toUnit == "feet") return value * 5280;
        if (fromUnit == "feet" && toUnit == "miles") return value / 5280;

        // Weight
        if (fromUnit == "grams" && toUnit == "kilograms") return value * 0.001;
        if (fromUnit == "kilograms" && toUnit == "grams") return value * 1000;
        if (fromUnit == "pounds" && toUnit == "ounces") return value * 16;
        if (fromUnit == "ounces" && toUnit == "pounds") return value / 16;

        // Temperature
        if (fromUnit == "celsius" && toUnit == "fahrenheit") return (value * 9 / 5) + 32;
        if (fromUnit == "fahrenheit" && toUnit == "celsius") return (value - 32) * 5 / 9;
        if (fromUnit == "celsius" && toUnit == "kelvin") return value + 273.15;
        if (fromUnit == "kelvin" && toUnit == "celsius") return value - 273.15;
        throw new Exception("Unsupported conversion");

    }
}
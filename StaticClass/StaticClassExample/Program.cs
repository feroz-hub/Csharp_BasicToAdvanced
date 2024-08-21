using StaticClassLibrary;

class Program
{
    static void Main()
    {
        // Calling the static class
        Console.WriteLine(Country.CountryName);
        Console.WriteLine(Country.Capital);
        Console.WriteLine(Country.GetNoOfUnionTerritories());
        
    }
}
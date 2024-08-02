namespace PartialClassClassLibrary;

public partial class Product
{
    // implementation of partial method
    partial void GetTax()
    {
        var tax = Cost * 10 / 100;
         Console.WriteLine($"Tax:{tax}");
    }
}
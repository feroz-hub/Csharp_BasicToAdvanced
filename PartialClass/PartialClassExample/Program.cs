using PartialClassClassLibrary;

class Program
{
    static void Main()
    {
        // create object for partial class
        var product = new Product
        {
            ProductId = 101,
            Cost = 1000
        };
        //access method
        product.CallGetTax();
        Console.ReadLine();
    }
}
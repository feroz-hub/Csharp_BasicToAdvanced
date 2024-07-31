
using ClassLibrary1;

namespace MethodsExample;

class Program
{
    static void Main(string[] args)
    {

        Bird[] birds = [new Sparrow(), new Penguin()];
        foreach (var bird in birds)
        {
            bird.Eat();
            if (bird is IFlyable flyable)
            {
                flyable.Fly();
            }
            else
            {
                Console.WriteLine($"{bird.GetType().Name} can't fly'");
            }
        }
        const string developerName = "Feroz";
        //create reference variables

        //create object
        var product1 = new Product();
        Product.TotalNoProducts++;
        var product2 = new Product();
        Product.TotalNoProducts++;
        var product3 = new Product();
        Product.TotalNoProducts++;
        
        //initialize fields
        product1.SetProductId(1001);
        product1.SetProductName("Mobile");
        product1.SetCost(10000); 
        product1.SetQuantity(4564) ;
        
        //initialize fields
        product2.SetProductId(1002);
        product2.SetProductName("Laptop");
        product2.SetCost(231000); 
        product2.SetQuantity(4564) ;
        //initialize fields
        product3.SetProductId(1001);
        product3.SetProductName("CPU");
        product3.SetCost(100000); 
        product3.SetQuantity(4564) ;
        
        //call method
        
        product1.CalculateTax();
        product2.CalculateTax();
        product3.CalculateTax();
        
        
        
        Console.WriteLine(developerName);
        Console.WriteLine("Product 1");
        Console.WriteLine("Product Id:"+product1.GetProductId());
        Console.WriteLine("Product Name:" + product1.GetProductName());
        Console.WriteLine("Product Cost:" + product1.GetCost());
        Console.WriteLine("Product Quantity:" + product1.GetQuantity());
        Console.WriteLine("tax:" + product1.GetTax());
        Console.WriteLine("Date of Purchase:"+product1.GetDateOfPurchase());
        
        Console.WriteLine("\nProduct 2");
        Console.WriteLine("Product Id:"+product2.GetProductId());
        Console.WriteLine("Product Name:" + product2.GetProductName());
        Console.WriteLine("Product Cost:" + product2.GetCost());
        Console.WriteLine("Product Quantity:" + product2.GetQuantity());
        Console.WriteLine("tax:"+product2.GetTax());
        Console.WriteLine("Date of Purchase:"+product2.GetDateOfPurchase());

        Console.WriteLine("\nProduct 3");
        Console.WriteLine("Product Id:"+product3.GetProductId());
        Console.WriteLine("Product Name:" + product3.GetProductName());
        Console.WriteLine("Product Cost:" + product3.GetCost());
        Console.WriteLine("Product Quantity:" + product3.GetQuantity());
        Console.WriteLine("tax:"+product3.GetTax());
        Console.WriteLine("Date of Purchase:"+product3.GetDateOfPurchase());

        var totalQuantity = product1.GetQuantity() + product2.GetQuantity() + product3.GetQuantity();
        Console.WriteLine("Total Quantity: " + totalQuantity);
        Console.WriteLine("TotalNumberOfProduct:"+Product.TotalNoProducts);
        Console.WriteLine("Category Of Product:"+Product.CategoryName);


        Console.ReadKey();
    }
}
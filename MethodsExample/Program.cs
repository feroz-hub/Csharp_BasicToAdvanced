
using ClassLibrary1;

namespace MethodsExample;

class Program
{
    static void Main(string[] args)
    {

        Bird[] birds = [new Sparrow(), new Penguin()];
        Console.WriteLine("LSP Example");
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
        Console.WriteLine(" ");
        const string developerName = "Feroz";
        //create reference variables

        //create object
        var product1 = new Product();
        Product.SetTotalNumberOfProducts(Product.GetTotalNumberOfProducts()+1);
        var product2 = new Product();
        Product.SetTotalNumberOfProducts(Product.GetTotalNumberOfProducts()+1);
        var product3 = new Product();
        Product.SetTotalNumberOfProducts(Product.GetTotalNumberOfProducts()+1);

        
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
        
        //call method with named arguments
        var q = 7.4;
        product1.Calculate(percentage: q);
        
        //ref 
        var p = 7.5;
        product2.CalculateTax(ref p);
        Console.WriteLine("ref P is "+p);
        
        //out variable declaration
        product2.Calculate(out double t);
        Console.WriteLine("out is "+t);
        // in parameter modifier
        double x = 4.4;
        product3.CalculateWithIn(in x);
        //method overloading
        product3.CalculateTax(10000,3.4);
        
        
        
        
        
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

        var totalQuantity = Product.GetTotalQuantity(product1, product2, product3);
        Console.WriteLine("Total Quantity: " + totalQuantity);
        Console.WriteLine("TotalNumberOfProduct:"+Product.GetTotalNumberOfProducts());
        Console.WriteLine("Category Of Product:"+Product.CategoryName);


        Console.ReadKey();
    }
}
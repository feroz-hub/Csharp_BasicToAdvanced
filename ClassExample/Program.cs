using ClassLibrary1;

namespace ClassExample;


class Program
{
    static void Main(string[] args)
    {
        //create reference variables
        Product product1, product2, product3;
        
        //create object
        product1 = new Product();
        product2 = new Product();
        product3 = new Product();
        
        //initialize fields
        product1.ProductId = 1001;
        product1.ProductName = "Mobile";
        product1.Cost = 10000;
        product1.Quantity = 3999;
        
        //initialize fields
        product2.ProductId = 1002;
        product2.ProductName = "Watch";
        product2.Cost = 10000;
        product2.Quantity = 3999;
        //initialize fields
        product3.ProductId = 1002;
        product3.ProductName = "Laptop";
        product3.Cost = 10000;
        product3.Quantity = 3999;

        Console.WriteLine("Product 1");
        Console.WriteLine("Product Id:"+product1.ProductId);
        Console.WriteLine("Product Name:" + product1.ProductName);
        Console.WriteLine("Product Cost:" + product1.Cost);
        Console.WriteLine("Product Quantity:" + product1.Quantity);
        Console.WriteLine("Product 2");
        Console.WriteLine("Product Id:"+product2.ProductId);
        Console.WriteLine("Product Name:" + product2.ProductName);
        Console.WriteLine("Product Cost:" + product2.Cost);
        Console.WriteLine("Product Quantity:" + product2.Quantity);
        Console.WriteLine("Product 3");
        Console.WriteLine("Product Id:"+product3.ProductId);
        Console.WriteLine("Product Name:" + product3.ProductName);
        Console.WriteLine("Product Cost:" + product3.Cost);
        Console.WriteLine("Product Quantity:" + product3.Quantity);

    }
}

public class InternationalProduct : Product
{
    public void Method1()
    {
        ProductId = 1;//not valid
        ProductName = "adf"; //accessible
        Cost = 1000;// not valid
    }
}

public class otherclass2
{
    public void Method1()
    {
        var product=new Product();
        product.ProductId = 1;//not valid
        product.ProductName = "adf"; //not valid
        product.Cost = 1000;//not valid
    }
}
namespace ClassLibrary1;

public class Product
{
    private int ProductId;
    private string ProductName;
    public double Cost;
    public double Tax;
    public static int TotalNoProducts;
    public const string CategoryName = "Electronic";
    public readonly string DateOfPurchase;
    public int Quantity;

    //Constructor
    public Product()
    {
        DateOfPurchase = DateTime.Now.ToShortDateString();
    }
    
    //method
    public void CalculateTax()
    {
        //create local var

        double t;
        //calculate tax
        if (Cost<=20000)
        {
            t = Cost * 10 / 1000;
        }
        else
        {
            t = Cost * 12.5 / 1000;
        }

        Tax = t;
    }
    
    //Set method for ProductId
    public void SetProductId(int value)
    {
        ProductId = value;
    }
    
    //Get method for ProductId
    public int GetProductId()
    {
        return  ProductId;
    }
    
    //Set method for ProductName
    public void SetProductName(string value)
    {
        ProductName = value;
    }
    
    //Get method for ProductName
    public string GetProductName()
    {
        return  ProductName;
    }
    //Set method for Cost
    public void SetCost(double value)
    {
        Cost = value;
    }
    
    //Get method for Cost
    public double GetCost()
    {
        return  Cost;
    }
    //Set method for Tax
    public void SetTax(double value)
    {
        Tax = value;
    }
    
    //Get method for Tax
    public double GetTax()
    {
        return Tax;
    }
    //Set method for Quantity
    public void SetQuantity(int value)
    {
        Quantity = value;
    }
    
    //Get method for Quantity
    public int GetQuantity()
    {
        return  Quantity;
    }
    
    //Get method for DateOfPurchase
    public string GetDateOfPurchase()
    {
        return DateOfPurchase;
    }
    
    
}


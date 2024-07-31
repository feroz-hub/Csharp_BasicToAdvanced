namespace ClassLibrary1;

public class Product
{
    private int _productId;
    private string _productName;
    private double _cost;
    private double _tax;
    public static int TotalNoProducts;
    public const string CategoryName = "Electronic";
    private readonly string _dateOfPurchase;
    private int _quantity;

    //Constructor
    public Product()
    {
        _dateOfPurchase = DateTime.Now.ToShortDateString();
    }
    
    //method with default arguments
    public void Calculate( double percentage=3.4)
    {
        //create local var
        double t;
        //calculate tax
        if (_cost <= 20000)
            t = _cost * 10 / 1000;
        else
            t = _cost * percentage / 1000;

        _tax = t;
    }
    //method with ref parameter modifier
    public void CalculateTax(ref double percentage)
    {
        //create local var

        percentage = 10.5;
        double t;
        //calculate tax
        if (_cost <= 20000)
            t = _cost * 10 / 1000;
        else
            t = _cost * percentage / 1000;

        _tax = t;
    }
    
    //method with out parameter modifier
    public void Calculate(out double percentage)
    {
        //create local var

        percentage = 10.5;
        double t;
        //calculate tax
        if (_cost <= 20000)
            t = _cost * 10 / 1000;
        else
            t = _cost * percentage / 1000;

        _tax = t;
    }

     
    //method with out parameter modifier
    public void CalculateWithIn(in double percentage)
    {
        //create local var

        //percentage = 10.5;
        double t;
        //calculate tax
        if (_cost <= 20000)
            t = _cost * 10 / 1000;
        else
            t = _cost * percentage / 1000;

        _tax = t;
    }
    public void CalculateTax(double cost, double percentage)
    { 
        //create local var

        double t;
        //calculate tax
        if (cost <= 50000)
            t = cost * 5 / 1000;
        else
            t = cost * percentage / 1000;

        _tax = t;
        
    }
    
    //Set method for ProductId
    public void SetProductId(int _productId)
    {
        this._productId = _productId;
    }
    
    //Get method for ProductId
    public int GetProductId()
    {
        return  _productId;
    }
    
    //Set method for ProductName
    public void SetProductName(string value)
    {
        _productName = value;
    }
    
    //Get method for ProductName
    public string GetProductName()
    {
        return  _productName;
    }
    //Set method for Cost
    public void SetCost(double value)
    {
        _cost = value;
    }
    
    //Get method for Cost
    public double GetCost()
    {
        return  _cost;
    }
    //Set method for Tax
    public void SetTax(double value)
    {
        _tax = value;
    }
    
    //Get method for Tax
    public double GetTax()
    {
        return _tax;
    }
    //Set method for Quantity
    public void SetQuantity(int value)
    {
        _quantity = value;
    }
    
    //Get method for Quantity
    public int GetQuantity()
    {
        return  _quantity;
    }
    
    //Get method for DateOfPurchase
    public string GetDateOfPurchase()
    {
        return _dateOfPurchase;
    }
    
    //static method
    public static void SetTotalNumberOfProducts(int value)
    {
        TotalNoProducts = value;
    }
    public static int GetTotalNumberOfProducts()
    {
        return TotalNoProducts;
    }
    
    //static method
    public static int GetTotalQuantity(Product product1, Product product2, Product product3)
    {
        var total = product1.GetQuantity() + product2.GetQuantity() + product3.GetQuantity();
        return total;
    }
    
    
}


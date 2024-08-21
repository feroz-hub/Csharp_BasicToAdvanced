namespace PartialClassClassLibrary;

public partial class Product
{
    public double Cost { get; set; }
    
    //public method to call partial method
    public void CallGetTax()
    {
        GetTax();
    }

}
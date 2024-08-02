namespace PartialClassClassLibrary;

public partial class Product
{
    public int ProductId { get; set; }
    //declaration of partial method
    partial void GetTax();
} 
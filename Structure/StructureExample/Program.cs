using StructureClassLibrary;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the Category struct
        var category = new Category(20,"Book");

        // category.CategoryId = 0;
        //     category.CategoryName = "Food";
        //

        // Display the properties of the category instance
        Console.WriteLine($"CategoryId: {category.CategoryId}");
        Console.WriteLine($"CategoryName: {category.CategoryName}");
        Console.WriteLine($"CategoryName Length: {category.GetCategoryNameLength()}");
        
       
    }
}
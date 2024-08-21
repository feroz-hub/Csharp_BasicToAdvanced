using System.ComponentModel.DataAnnotations;

namespace StructureClassLibrary;

public struct Category(int categoryId, string categoryName)
{
    public int CategoryId { get; set; } = categoryId;

    public string CategoryName { get; set; } = categoryName;

    //method GetCategoryNameLength
    public int GetCategoryNameLength()
    {
        return CategoryName.Length;
    }
    
}
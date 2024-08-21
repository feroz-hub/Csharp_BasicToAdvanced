public class ToyBox
{
    private string[] toys = ["Car", "Doll", "Puzzle"];

    // Method to get a reference to a specific toy
    public ref string GetToy(int index)
    {
        return ref toys[index];
    }
}

public class Warehouse
{
    private int[] itemQuantities = { 100, 200, 150 }; // Quantities of items in different bins

    // Method to get a reference to the quantity of an item in a specific bin
    public ref int GetItemQuantity(int binIndex)
    {
        return ref itemQuantities[binIndex];
    }
}


class Student
{
    //public field
    public int Grade = 2;

    //public method
    public void PrintGrade()
    {
        Console.WriteLine("Grade:"+Grade);
    }

    public ref int DoWork()
    {
        return ref Grade;
    }
    
}

class Program
{
    static void Main()
    {
        //creating object for student
        var student = new Student();
        
        // call PrintGrade
        student.PrintGrade();
        
        // call ref DoWork
        ref int g = ref student.DoWork();
        
        //update the value of 'ref return'
        
        g = 5;
        // call PrintGrade after updating the value of 'ref return'
        student.PrintGrade();
        
        var myToyBox = new ToyBox();

        // Get a reference to the first toy
        ref var myToy = ref myToyBox.GetToy(0);

        // Change the toy using the reference
        myToy = "Robot";

        // Print all toys to see the change
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(myToyBox.GetToy(i));
        }
        var myWarehouse = new Warehouse();

        // Get a reference to the quantity of the item in the second bin
        ref var quantity = ref myWarehouse.GetItemQuantity(1);

        // Update the quantity using the reference
        quantity += 50; // New stock arrived, increase the quantity

        // Print all item quantities to see the change
        for (var i = 0; i < 3; i++)
        {
            Console.WriteLine($"Bin {i + 1}: {myWarehouse.GetItemQuantity(i)} items");
        }
        Console.ReadKey();
        

    }
    
}
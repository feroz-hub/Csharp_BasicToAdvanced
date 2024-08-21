
using OperatorsSharedKernel;

class Program
{
    static void Main()
    {
        // Creating Instance
        object obj1 = new ProjectManager { Name = "Alice", Department = "HR" };
        object obj2 = new Developer { Name = "Bob", ProgrammingLanguage = "C#" };
        object obj3 = new Customer { CustomerId = "C12334" };
        object obj4 = "Just a string";
        object obj5 = new Button();

        // Scenario 1: Safe casting to a derived type using 'as'
        // Use 'as' when you want to try casting an object to a specific derived type, and
        // if it fails (i.e., the object is not of the derived type), you want to handle it gracefully.
        
        Console.WriteLine("Safe Casting to Derived Types:");
        ProjectManager manager = obj1 as ProjectManager;
        if (manager != null)
        {
            Console.WriteLine($"Successfully cast to Manager. Department: {manager.Department}");
        }

        Developer developer = obj2 as Developer;
        if (developer != null)
        {
            Console.WriteLine($"Successfully cast to Developer. Programming Language: {developer.ProgrammingLanguage}");
        }

        // Scenario 2: Handling cast to unrelated types
        // Use 'as' when casting to an unrelated type where a regular cast would throw an exception.
        // 'as' will return null instead, allowing you to check and handle the situation without an exception.
        
        Console.WriteLine("\nAttempting to cast to an unrelated type:");
        ProjectManager wrongCast = obj3 as ProjectManager;
        if (wrongCast == null)
        {
            Console.WriteLine("obj3 could not be cast to Manager.");
        }

        // Scenario 3: Casting to an interface
        // Use 'as' when you want to safely cast an object to an interface.
        // This is useful when you're working with objects that may or may not implement a particular interface.
        
        Console.WriteLine("\nCasting to an Interface:");
        IProcessable processable = obj5 as IProcessable;
        if (processable != null)
        {
            processable.Process();
        }
        else
        {
            Console.WriteLine("obj5 could not be cast to IProcessable.");
        }

        // Scenario 4: Casting to a base class
        // Use 'as' when you're casting to a base class and want to ensure that the object
        // is either of that type or derived from it. This is useful in inheritance hierarchies.
        
        Console.WriteLine("\nCasting to a Base Class:");
        UiComponent uiComponent = obj5 as UiComponent;
        if (uiComponent != null)
        {
            uiComponent.Render();
        }
        else
        {
            Console.WriteLine("obj5 could not be cast to UIComponent.");
        }

        // Scenario 5: Handling strings
        // Use 'as' when working with strings to avoid exceptions when an object might not be a string.
        
        Console.WriteLine("\nHandling Strings:");
        string str = obj4 as string;
        if (str != null)
        {
            Console.WriteLine($"Successfully cast to string: {str}");
        }
        else
        {
            Console.WriteLine("obj4 could not be cast to string.");
        }

        Console.ReadLine();
    }
}
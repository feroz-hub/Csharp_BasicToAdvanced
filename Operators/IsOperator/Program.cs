using IsOperator;

class Program
{
    static void Main()
    {
        // Creating Instance
        object obj1 = new ProjectManager { Name = "Alice", Department = "HR" };
        object obj2 = new Developer { Name = "Bob", ProgrammingLanguage = "C#" };
        object obj3 = new Customer { CustomerId = "C12334" };
        object obj4 = "Just a string";
        
        // Basic Type Checking
        
        Console.WriteLine("Basic Type Checking");
        if (obj1 is ProjectManager)
        {
            Console.WriteLine("obj1 is of type ProjectManager");
        }

        if (obj2 is Developer)
        {
            Console.WriteLine("obj2 is type of Developer");
        }

        if (obj3 is Customer)
        {
            Console.WriteLine("obj3 is type of Customer");
        }

        if (obj4 is string)
        {
            Console.WriteLine("obj4 is type of string");
        }
        
        // Pattern Matching with is
        Console.WriteLine("\nPattern Matching with is:");
        if (obj1 is ProjectManager projectManager)
        {
            Console.WriteLine($"obj1 is a ProjectManager managing the {projectManager.Department} department");
        }

        if (obj2 is Developer developer)
        {
            Console.WriteLine($"obj2 is a Developer working with {developer.ProgrammingLanguage}.");
        }
        
        // Checking for null Values
        Console.WriteLine("\nChecking for null Values");
        object? nullObj = null;
        if (nullObj is null)
        {
            Console.WriteLine("nullObj is null.");
        }
        
        // Checking type hierarchy (Employee base class)
        
        Console.WriteLine("\nChecking type hierarchy ");

        if (obj1 is Employee employee1)
        {
            Console.WriteLine($"{employee1.Name} is an Employee (or derived from Employee)");
        }

        if (obj2 is Employee employee2)
        {
            Console.WriteLine($"{employee2.Name} is an Employee (or derived from Employee)");
        }
        
        // Handling non-matching type
        
        Console.WriteLine("\nHandling Non-Matching Types:");
        if (obj3 is not Employee)
        {
            Console.WriteLine("obj3 is not an Employee");
        }
        
        // Using is in a switch statement (c# 7.0 and later)
        Console.WriteLine("\nUsing is in a switch statement");
        ProcessCommand(new StartCommand());
        ProcessCommand(new StopCommand());
        ProcessCommand(new PauseCommand());
        
        
    }

    private static void ProcessCommand(object command)
    {
        switch (command)
        {
            case StartCommand startCommand:
                Console.WriteLine("Received a StartCommand.");
                break;  
            case StopCommand stopCommand:
                Console.WriteLine("Received a stop Command");
                break;
            case PauseCommand pauseCommand:
                Console.WriteLine("Received a PauseCommand");
                break;
            default:
                Console.WriteLine("UnKnown Command.");
                break;
        }
    }

    private class StartCommand;

    private class StopCommand;

    private class PauseCommand;
}
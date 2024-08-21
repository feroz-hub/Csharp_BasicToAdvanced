namespace Null_CoalescingOperator;

class Program
{
    static void Main(string[] args)
    {
        // Scenario 1: User Input Handling
        // In real-time applications, user input might be null if the user doesn't provide a value.
        // Use the null-coalescing operator to assign a default value in such cases.
        
        Console.WriteLine("Please enter your name:");
        string? userName = Console.ReadLine();
        string greetingName =string.IsNullOrEmpty( userName) ? "Guest":userName; // If userName is null, assign "Guest"
        Console.WriteLine($"Hello, {greetingName}!");
        
        // Real-time usage: Ensuring that the application doesn't crash or behave unexpectedly when the user input is null.

        // Scenario 2: Reading Configuration Settings
        // Often, configuration settings might be missing or null, especially when reading from a file or environment variables.
        // Use the null-coalescing operator to provide a default value when a setting is not found.
       
        string configValue = GetConfigValue("AppTheme") ?? "Light"; // Default to "Light" if not found
        Console.WriteLine($"Application theme is set to: {configValue}");
        // Real-time usage: Ensuring that the application can still operate with sensible defaults when configurations are missing.

        // Scenario 3: Dealing with Nullable Types
        // When working with nullable types (e.g., int?, double?), a null value might indicate that a value is optional or hasn't been set.
        // Use the null-coalescing operator to provide a fallback value.
        
        int? maxUsers = GetMaxUsersSetting(); // Nullable type
        int maxUsersAllowed = maxUsers ?? 100; // Default to 100 if maxUsers is null
        Console.WriteLine($"Maximum users allowed: {maxUsersAllowed}");
        
        // Real-time usage: Safely handling nullable types without throwing exceptions, using defaults when necessary.

        // Scenario 4: Database Query Results
        // When querying a database, you might receive null values if no data is found.
        // Use the null-coalescing operator to handle null results gracefully.
       
        string customerName = GetCustomerNameFromDatabase(123) ?? "Unknown Customer";
        Console.WriteLine($"Customer Name: {customerName}");
        // Real-time usage: Providing fallback values when dealing with data retrieval, preventing null reference exceptions.

        // Scenario 5: Working with Collections
        // When retrieving items from a collection, a null value might indicate that the item is not present.
        // Use the null-coalescing operator to handle the absence of items gracefully.
        
        string[] products = GetProductList();
        string firstProduct = products?[0] ?? "No products available";
        Console.WriteLine($"First product: {firstProduct}");
        // Real-time usage: Safely handling collections where items may or may not be present, using default values when necessary.

        Console.ReadLine();
    }

    // Simulated method to get a configuration value (could be null)
    static string GetConfigValue(string key)
    {
        // In a real-world scenario, this would read from a config file or environment variable
        return null; // Simulate a missing config value
    }

    // Simulated method to get the max users setting (nullable type)
    static int? GetMaxUsersSetting()
    {
        // In a real-world scenario, this might come from a database or config file
        return null; // Simulate that the setting is not set
    }

    // Simulated method to get a customer name from a database (could return null)
    static string GetCustomerNameFromDatabase(int customerId)
    {
        // In a real-world scenario, this would query a database
        return null; // Simulate no matching customer found
    }

    // Simulated method to get a list of products (could be empty or null)
    static string[] GetProductList()
    {
        // In a real-world scenario, this might query a database or an API
        return null; // Simulate no products available
    }
}
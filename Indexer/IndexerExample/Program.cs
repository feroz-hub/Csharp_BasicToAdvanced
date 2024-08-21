using IndexerClassLibrary;

class Program
{
    static void Main(string[] args)
    {
        var car = new Car();
      
        car[1] = "World";
        car[2] = "!";

        Console.WriteLine(car[0]); // Output: Hello
        car[0] = "Hello";
        Console.WriteLine(car[0]);
        Console.WriteLine(car[1]); // Output: World
        Console.WriteLine(car[2]); // Output: !
        Console.WriteLine(car["First"]);
        
    }
}

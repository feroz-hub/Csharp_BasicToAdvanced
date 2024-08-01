namespace InheritanceClassLibrary;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void Eat(){
        System.Console.WriteLine("I am eating");
    }

    public void Sleep(){
        System.Console.WriteLine("I am sleeping");
    }
    
}

public class Teacher : Person
{
    public void Teach(){
        System.Console.WriteLine("I am teaching");
    }
}
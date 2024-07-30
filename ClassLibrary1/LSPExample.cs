namespace ClassLibrary1;

public class Bird
{
    public virtual void Eat()
    {
        Console.WriteLine("Bird is eating");
    }
}

public interface IFlyable
{
    void Fly();
}

public class Sparrow : Bird, IFlyable
{
    public void Fly()
    {
        Console.WriteLine("Sparrow is flying");
    }

    public override void Eat()
    {
        Console.WriteLine("Sparrow is eating");
    }
}

public class Penguin : Bird
{
    public override void Eat()
    {
        Console.WriteLine("Penguin is eating");
    }
}
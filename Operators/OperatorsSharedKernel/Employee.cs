namespace OperatorsSharedKernel;

public class Employee
{
    public string? Name { get; set; }
}

public class ProjectManager : Employee
{
    public string? Department { get; set; }
}

public class Developer : Employee
{
    public string? ProgrammingLanguage { get; set; }
}

public class Customer
{
    public string? CustomerId { get; set; }
}

public interface IProcessable
{
    void Process();
}

public class UiComponent
{
    public virtual void Render()
    {
        Console.WriteLine("Rendering UI Component");
    }
}

public class Button : UiComponent, IProcessable
{
    public void Process()
    {
        Console.WriteLine("Processing Button");
    }

    public override void Render()
    {
        Console.WriteLine("Rendering Button");
    }
}
using InterfaceClassLibrary;

class Program
{
    static void Main()
    {
        //create object
        var manager = new Manager(200,"Feroz","Chennai");
        Console.WriteLine("Object of class Manager");
        Console.WriteLine($"Employee Id: {manager.EmpId}");
        Console.WriteLine($"Employee Name: {manager.EmpName}");
        Console.WriteLine($"Location: {manager.Location}");
        Console.WriteLine($"Health Insurance Amount:{manager.GetHealthInsuranceAmount()}");
    
        Console.WriteLine();
        var salesPerson = new Salesman(300, "Ramesh", "Mumbai","east");
        Console.WriteLine("Object of class Salesman");
        Console.WriteLine($"Employee Id: {salesPerson.EmpId}");
        Console.WriteLine($"Employee Name: {salesPerson.EmpName}");
        Console.WriteLine($"Location: {salesPerson.Location}");
        Console.WriteLine($"Region: {salesPerson.Region}");
        Console.WriteLine($"Health Insurance Amount:{salesPerson.GetHealthInsuranceAmount()}");
        Console.WriteLine();
        //Dynamic + polymorphism with interfaces
        //create reference of parent interfaces(IEmployee)
        
        IEmployee employee;
        Console.WriteLine("Dynamic + polymorphism with interfaces");
        //create object of child class
        employee = new Manager(200, "Feroz", "Chennai");
        Console.WriteLine("Object of class Manager");
        Console.WriteLine($"Employee Id: {employee.EmpId}");
        Console.WriteLine($"Employee Name: {employee.EmpName}");
        Console.WriteLine($"Location: {employee.Location}");
        Console.WriteLine($"Health Insurance Amount:{employee.GetHealthInsuranceAmount()}");
        Console.WriteLine();
        
        employee = new Salesman(300, "Ramesh", "Mumbai", "east");
        Console.WriteLine("Object of class Salesman");
        Console.WriteLine($"Employee Id: {employee.EmpId}");
        Console.WriteLine($"Employee Name: {employee.EmpName}");
        Console.WriteLine($"Location: {employee.Location}");
        Console.WriteLine($"Region: {((Salesman)employee).Region}");
        Console.WriteLine($"Health Insurance Amount:{employee.GetHealthInsuranceAmount()}");
        
        Console.WriteLine();
        Console.WriteLine("Multiple Interfaces");
        IPerson person;
        person = new Manager(200, "Feroz", "Chennai");
        person.DateOfBirth = Convert.ToDateTime("2001-05-06");
        Console.WriteLine($"Person Age: {person.GetAge()}");

    }
}
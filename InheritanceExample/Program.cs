using InheritanceClassLibrary;

class Program
{
    static void Main()
    {
        //create object
        // var emp = new Employee(101,"John","Mumbai");
        // Console.WriteLine("Object of parent class [Employee]");
        // Console.WriteLine($"Employee Id: {emp.EmployeeId}");
        // Console.WriteLine($"Employee Name: {emp.EmployeeName}");
        // Console.WriteLine($"Location: {emp.Location}");
        // Console.WriteLine();
        
        //create object
        var manager = new Manager(200,"Feroz","Chennai","IT");
        
        Console.WriteLine("Object of child class [Manager]");
        Console.WriteLine($"Employee Id: {manager.EmployeeId}");
        Console.WriteLine($"Employee Name: {manager.EmployeeName}");
        Console.WriteLine($"Location: {manager.Location}");
        Console.WriteLine($"Department Name: {manager.Department}");
        Console.WriteLine($"Sales of the year:{manager.GetTotalSalesOfTheYear()}");
        Console.WriteLine($"Department Full Name:{manager.GetFullDepartmentName()}");
        Console.WriteLine($"Health Insurance Amount:{manager.GetHealthInsuranceAmount("Feroz")}");
        Console.WriteLine($"NetSalary:{manager.NetSalary(10000,100)}");
        
        // creat object for child class salesman
        var salesman = new Salesman(202,"John","Kolkata","East");
        Console.WriteLine();
        Console.WriteLine("Object of child class [Salesman]");
        Console.WriteLine($"Employee Id: {salesman.EmployeeId}");
        Console.WriteLine($"Employee Name: {salesman.EmployeeName}");
        Console.WriteLine($"Location: {salesman.Location}");
        Console.WriteLine($"Region: {salesman.Region}");
        Console.WriteLine($"Sales of the Month:{salesman.GetSalesOfCurrentMonth()}");
        Console.WriteLine();
    }
}
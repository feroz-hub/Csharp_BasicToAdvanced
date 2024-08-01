namespace InheritanceClassLibrary;

public class Salesman(int EmployeeId, string EmployeeName, string Location,string Region) :Employee(EmployeeId, EmployeeName, Location)
{
    public string Region { get; set; } = Region;
    
    //method
    public long GetSalesOfCurrentMonth()
    {
        return 1000;
    }

    public override double NetSalary(int salary, int tax)
    {
        return salary - tax;
    }
}
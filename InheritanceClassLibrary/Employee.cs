namespace InheritanceClassLibrary;

public abstract class Employee(int EmployeeId,string EmployeeName,string Location)
{
    public int EmployeeId { get; set; } = EmployeeId;
    public string EmployeeName { get; set; } = EmployeeName;
    public string Location { get; set; } = Location;
    //method
    public string GetHealthInsuranceAmount()
    {
        return "$100";
    }
    // virtual method 
    public virtual string GetHealthInsuranceAmount(string name)
    {
        return "Parent Class Method:$100";
    }

    // abstract method
    public abstract string NetSalary(int salary, int tax);

}
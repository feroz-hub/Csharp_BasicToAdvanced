namespace InheritanceClassLibrary;

public class Manager(int EmployeeId, string EmployeeName, string Location ,string Department) :Employee(EmployeeId, EmployeeName, Location)
{
   
    //property
    public string Department { get; set; } = Department;

    //method
    public long GetTotalSalesOfTheYear()
    {
        return 10000;
    }

    public string GetFullDepartmentName()
    {
        return Department + " at " + base.Location;
    }
    //method hiding
    public new string GetHealthInsuranceAmount()
    {
        return "$200";
    }

    public sealed override string GetHealthInsuranceAmount(string name)
    {
       Console.WriteLine( base.GetHealthInsuranceAmount(name));
        return "$500";
    }

    public override string NetSalary(int salary, int tax)
    {
        return "The Manager salary"+(salary-tax);
    }
}
namespace InterfaceClassLibrary;

public class Manager(int empId,string empName,string location):IEmployee
{
    public string GetHealthInsuranceAmount()
    {
        return "Health premium amount for manager is 1000";
    }
    public int EmpId { get; set; } = empId;
    public string EmpName { get; set; } = empName;
    public string Location { get; set; } = location;
    public DateTime DateOfBirth { get; set; }
    public int GetAge()
    {
        var a = Convert.ToInt32((DateTime.Now - DateOfBirth).TotalDays / 365);
        return a;
    }
}
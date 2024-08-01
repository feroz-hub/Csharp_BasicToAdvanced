namespace InterfaceClassLibrary;

public class Salesman(int empId,string empName,string location,string region):IEmployee
{
    public string GetHealthInsuranceAmount()
    {
        return "Health premium amount for salesman is 500";
    }

    public int EmpId { get; set; } = empId;
    public string EmpName { get; set; } = empName;
    public string Location { get; set; } = location;
    public string Region { get; set; } = region;
    public DateTime DateOfBirth { get; set; }
    public int GetAge()
    {
        throw new NotImplementedException();
    }
}
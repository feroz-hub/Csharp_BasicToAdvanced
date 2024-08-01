namespace InterfaceClassLibrary;

public interface IEmployee:IPerson
{
    //abstract method
    string GetHealthInsuranceAmount();
    
    // auto-properties
    int EmpId { get; set; }
    string EmpName { get; set; }
    string Location { get; set; }
}
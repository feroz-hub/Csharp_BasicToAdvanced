namespace InterfaceClassLibrary;

public interface IPerson
{
    DateTime DateOfBirth { get; set; }
    int GetAge();
}
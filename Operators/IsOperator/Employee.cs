namespace IsOperator;

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
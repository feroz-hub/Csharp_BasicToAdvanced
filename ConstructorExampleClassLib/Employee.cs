namespace ConstructorExampleClassLib;

//Normal Parameter Constructor
public class Employee
{
    public int EmpId { get; set; }
    public string EmpName { get; set; }
    public string Job{ get; set; }

    //static field
    public static string CompanyName { get; set; }
    
    //Constructor Overloading

    //Default Constructor
    // Constructor 1
    public Employee()
    {
        EmpId = 1;
    }

    //instance Constructor 
    // Constructor2
    public Employee(int EmpId,string EmpName,string Job)
    {
        this.EmpId = EmpId;
        this.EmpName = EmpName;
        this.Job = Job;
    }

    //Parameterized Constructor
    // Constructor3
    public Employee(int EmpId, string EmpName)
    {
        this.EmpId = EmpId;
        this.EmpName = EmpName;
    }

    //Copy Constructor
    //static Constructor
    static Employee()
    {
        Console.WriteLine("Static Constructor");
        CompanyName = "TCS";
    }
}
public class Student(int StdId,string StdName,float StdMark)
{
    public int StdId { get; set; } = StdId;
    public string StdName { get; set; } = StdName;
    public float StdMark { get; set; } = StdMark;
}
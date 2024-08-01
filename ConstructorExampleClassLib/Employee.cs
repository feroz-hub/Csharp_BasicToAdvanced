namespace ConstructorExampleClassLib;

//Normal Parameter Constructor
public class Employee
{
    private int _empId;
    private string _empName;
    private string _job;
    private double _salary;
    private double _tax;
    
    //static field
    private static string _companyName { get; set; }
    //automatic property
    public string Address { set; get; }

    //automatic property
    public string City { set; get; }
    //instance property
    public int EmpId
    {
        set
        {
            if (value>=100)
            {
                _empId = value;
            }
        }
        get => _empId;
    }

    public string EmpName
    {
        set
        {
            if (value.Length > 3)
            {
                _empName = value;
            }
        }
        get
        {
            return _empName;
        }
    }

    public string Job
    {
        set
        {
            if (value.Length > 3)
            {
                _job = value;
            }
        }
        get
        {
             return _job;
        }
    }

    public static string CompanyName
    {
        set
        {
            if (value.Length > 3)
            {
                _companyName = value;
            }
        }
        get
        {
            return _companyName;
        }
        
    }

    // readonly property
    public double NetSalary
    {
        get
        {
            return _salary - (_salary * _tax / 100);
        }
    }
    // readonly Property
    public double Salary
    {
        get
        {
            return _salary;
        }
    }
    // write only property
    
    public double Tax
    {
        set
        {
            if (value >= 0 && value<=100)
            {
                _tax = value;
            }
        }
    }

    //Default Constructor
    // Constructor 1
    public Employee()
    {
        _empId = 1;
        _salary = 10000;
    }

    //instance Constructor 
    // Constructor2
    public Employee(int EmpId,string EmpName,string Job)
    {
        this._empId = EmpId;
        this._empName = EmpName;
        this._job = Job;
        this._salary = 10000;
        
    }

    //Parameterized Constructor
    // Constructor3
    public Employee(int EmpId, string EmpName)
    {
        this._empId = EmpId;
        this._empName = EmpName;
        this._salary = 10000;

    }
    
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
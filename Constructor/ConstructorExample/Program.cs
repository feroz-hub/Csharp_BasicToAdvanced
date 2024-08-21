using ConstructorExampleClassLib;

class Program
{
    static void Main()
    {
        //create three object for Employee
        var employee1 = new Employee(101, "scoot");
        employee1.Job = "Software Engineer";
        employee1.Tax = 50;
        employee1.City = "Chennai";
        var employee2 = new Employee(102,"Feroz","Software Engineer");
        employee2.Tax = 20;
        var employee3 = new Employee();
        employee3.EmpId = 102;
        employee3.EmpName = "John";
        employee3.Job = "Manager";
        
        // object Initializer
        var employee4 = new Employee
        {
            EmpId = 201,
            EmpName = "Jane",
            Job = "HR"
        };
        //display field
        Console.WriteLine(Employee.CompanyName);
        Console.WriteLine("\nEmployee 1");
        Console.WriteLine($"ID: {employee1.EmpId}");
        Console.WriteLine($"Name: {employee1.EmpName}");
        Console.WriteLine($"Job: {employee1.Job}");
        Console.WriteLine($"Salary:{employee1.NetSalary}");
        Console.WriteLine($"City:{employee1.City}");
        Console.WriteLine();
        Console.WriteLine("Employee 2 ");
        Console.WriteLine($"ID: {employee2.EmpId}");
        Console.WriteLine($"Name: {employee2.EmpName}");
        Console.WriteLine($"Job: {employee2.Job}");
        Console.WriteLine($"Salary:{employee2.NetSalary}");
        Console.WriteLine();
        Console.WriteLine("Employee 3 with parameter less Constructor");
        Console.WriteLine($"ID: {employee3.EmpId}");
        Console.WriteLine($"Name: {employee3.EmpName}");
        Console.WriteLine($"Job: {employee3.Job}");
        Console.WriteLine($"Salary:{employee3.Salary}");
        
        Console.WriteLine("\nEmployee 4 with Object Initializer");
        Console.WriteLine($"ID: {employee4.EmpId}");
        Console.WriteLine($"Name: {employee4.EmpName}");
        Console.WriteLine($"Job: {employee4.Job}");
        Console.WriteLine($"Salary:{employee4.Salary}");
        
        Console.WriteLine();
        //Create Object for Student
        var student1 = new Student(1001, "John", 99);
        var student2 = new Student(1002, "Jane", 95);
        var student3 = new Student(1003, "Bob", 88);
        
        //display field
        Console.WriteLine("Student 1");
        Console.WriteLine($"ID: {student1.StdId}");
        Console.WriteLine($"Name: {student1.StdName}");
        Console.WriteLine($"Marks: {student1.StdMark}");
        Console.WriteLine();
        Console.WriteLine("Student 2");
        Console.WriteLine($"ID: {student2.StdId}");
        Console.WriteLine($"Name: {student2.StdName}");
        Console.WriteLine($"Marks: {student2.StdMark}");
        Console.WriteLine();
        Console.WriteLine("Student 3");
        Console.WriteLine($"ID: {student3.StdId}");
        Console.WriteLine($"Name: {student3.StdName}");
        Console.WriteLine($"Marks: {student3.StdMark}");
        Console.WriteLine();
        
        Console.ReadKey();
    }
}
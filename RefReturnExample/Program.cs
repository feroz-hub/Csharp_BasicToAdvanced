



class Student
{
    //public field
    public int Grade = 2;

    //public method
    public void PrintGrade()
    {
        Console.WriteLine("Grade:"+Grade);
    }

    public ref int DoWork()
    {
        return ref Grade;
    }
    
}

class Program
{
    static void Main()
    {
        //creating object for student
        var student = new Student();
        
        // call PrintGrade
        student.PrintGrade();
        
        // call ref DoWork
        ref int g = ref student.DoWork();
        
        //update the value of 'ref return'
        g = 5;
        // call PrintGrade after updating the value of 'ref return'
        student.PrintGrade();
        Console.ReadKey();

    }
    
}
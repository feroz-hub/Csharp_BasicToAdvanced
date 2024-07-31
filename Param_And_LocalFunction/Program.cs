class Sum
{
    //Without param 
    public int Add(int a, int b)
    {
        return a + b;
    }
    public int Add(params int[] numbers)
    {
        return numbers.Sum();
    }
}

class Student
{
    public void DisplayMark(int mark1,int mark2,int mark3)
    {
        Console.WriteLine("Mark1: " + mark1);
        Console.WriteLine("Mark2:" + mark2);
        Console.WriteLine("Mark3:" + mark3);
        //calling local function
        Console.WriteLine("local function Average Mark: " +getAverageMark());
        // calling static local function        
        Console.WriteLine("static local function Average Mark: " +getAverageMarks(mark1, mark2, mark3));
        
        // create local function
        double getAverageMark ()
        {
            double avg;
            avg = (double)(mark1 + mark2 + mark3) / 3;
            return avg;
        }
        // static local function
        static double getAverageMarks (int mark1, int mark2, int mark3)
        {
            double avg;
            avg = (double)(mark1 + mark2 + mark3) / 3;
            return avg;
        }
    }
}

class Program
{
    static void Main()
    { 
        var cal = new Sum();
        var x=cal.Add(1, 2, 3, 4);
        Console.WriteLine(x);
        
        var s = new Student();
        s.DisplayMark(70,46,45);
    }
}
namespace InheritanceClassLibrary;
//Multi-level Inheritance
public class Class
{
    public int Id { get; set; }
}

public class Student : Class
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class Subject : Student
{
    public string Name { get; set; }
    public int Mark { get; set; }
}
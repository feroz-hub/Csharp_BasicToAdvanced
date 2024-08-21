using EnumerationClassLibrary;

class Program
{
    static void Main()
    {
        var person = new Person();
        person.PersonName = "John";
        person.Email = "john123@gmail.com";
        person.AgeGroup = AgeGroupEnumeration.Adult;
        Console.WriteLine("Person:" + person.PersonName);
        Console.WriteLine("Email:" + person.Email);
        Console.WriteLine("AgeGroup:" + person.AgeGroup);

    }
}
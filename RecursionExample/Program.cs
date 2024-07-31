class Sample
{
    public double Fact(int n)
    {
        if (n == 0)
            return 1;
        return n * Fact(n - 1);
    }
}

class Program
{
    static void Main()
    {
        var sample = new Sample();
        Console.WriteLine(sample.Fact(5));
    }
}
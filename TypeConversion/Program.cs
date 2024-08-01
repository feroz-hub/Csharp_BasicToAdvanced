class Program
{
    static void Main()
    {
        //Implicit Casting
        
        //sbyte
        sbyte a = 127;
        //char
        char x = 'A';
        //int
        int b;
        //copy the value from 'a' to 'b'
        b = a;
        Console.WriteLine("Implicit cast from sbyte to int:"+b);
        b = x;
        Console.WriteLine("Implicit cast from char to int:"+b);
        
        //Explicit Casting
        //int
        int c = 100;
        
        //float
        float d;
        //explicit casting
        d = (float)c;
        Console.WriteLine("Explicit cast from int to float:"+d);
        //byte
        byte e;
        //explicit casting
        e = (byte)c;
        Console.WriteLine("Explicit cast from int to byte:"+e);
        
        //Parse
        string str = "123";
        int num = int.Parse(str);
        Console.WriteLine("Parse string to int:"+num);
        float num2 = float.Parse(str);
        Console.WriteLine("Parse string to float:"+num2);
        double num3 = double.Parse(str);
        Console.WriteLine("Parse string to double:"+num3);
        
        //TryParse
        string str2 = "123.45";
        
        bool isParsed = float.TryParse(str2, out float n);
        if (isParsed)
        {
            Console.WriteLine("TryParse string to int:"+n);
        }
        else
        {
            Console.WriteLine("TryParse failed");
        }
        //Convert
        string str3 = "123";
        int num4 = Convert.ToInt32(str3);
        Console.WriteLine("Convert string to int:"+num4);
        
    }
}
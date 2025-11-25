class Program
{
    static void PassReferenceType(int [] data)
    {
        data[3] = 12345;
        Console.WriteLine($"In the function RT, data[3] is {data[3]}");
    }
    static void PassByOut(out int a)
    {
        a = 17;
        Console.WriteLine($"In the out function, a is {a}");
    }

    static void PassByReference(ref int x)
    {
        x = 999;
        Console.WriteLine($"In the reference function, x is {x}");
    }

    static void PassByValue(int x)
    {
        x = 1001;
        Console.WriteLine($"In the function, x is {x}");
    }
    static void Main(string[] args)
    {
        System.Console.WriteLine("Hello, ReferenceApp!");

        int x = 10;
        int y = x;
        y++;
        Console.WriteLine($"{x} {y}");

        int [] a = {1,2,3,4,5,6};
        int [] b = a;

        b[3] = 111;
        Console.WriteLine($"{a[3]}, {b[3]}");

        PassByValue(x);
        Console.WriteLine($"In Main, x is {x}");

        PassByReference(ref x);
        Console.WriteLine($"In Main, x is {x}");

        int z;
        PassByOut(out z);
        Console.WriteLine($"In Main, z is {z}");

        PassReferenceType(a);
        foreach(int i in a)
        {
            Console.WriteLine($"In the main loop, i is {i}");
        }
    }
}
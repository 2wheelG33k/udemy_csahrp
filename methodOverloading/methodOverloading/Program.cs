namespace methodOverloading;

class Program
{
    static void Main(string[] args)
    {
        add();
        add(10, 20);
        add(100, 200, 400);
    }

    public static void add()
    {
        Console.WriteLine("Method with no parameters");
    }

    public static void add(int a, int b)
    {
        Console.WriteLine("Method with two parameters: " + a + " & " + b);
    }
    public static void add(int a, int b, int c)
    {
        Console.WriteLine("Method with three parameters: " + a + ", " + b + " & " + c);
    }
}
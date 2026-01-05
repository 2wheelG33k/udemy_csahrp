namespace methodOverld;

class MathOperations
{
    public static double sum(double num1, double num2) {
        return num1 + num2;
    }
    public static double sum(int num1, int num2) {
        return num1 + num2;
    }
    public static double sum(int num1, int num2, int num3) {
        return num1 + num2 + num3;
    }
    public static double difference(double num1, double num2) {
        return num1 - num2;
    }
    public static double product(double num1, double num2) {
        return num1 * num2;
    }
    public static double quotient(double num1, double num2) {
        if (num2 != 0) {
            return num1 / num2;
        } else {
            return 0; // Indicate division by zero
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Sum (double) : " + sum(10.0, 20.0));
        Console.WriteLine("Sum (int2) : " + sum(5, 9));
        Console.WriteLine("Sum (int3) : " + sum(11, 4, 31));
        Console.WriteLine("Difference : " + difference(30.0, 15.0));
        Console.WriteLine("Product : " + product(5.0, 4.0));
        Console.WriteLine("Quotient : " + quotient(50.0, 2.0));
    }
}
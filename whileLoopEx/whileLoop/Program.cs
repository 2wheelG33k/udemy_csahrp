namespace whileLoop;

class Program
{
    static void Main(string[] args)
    {
        int start = 5, end = 11;

        while (start <= end)
        {
            checkMultipleOfThree(start);
            start++;
        }
    }
    public static void checkMultipleOfThree(int num) {
        if(num % 3 == 0) {
            Console.WriteLine(num + " is a multiple of 3");
        }
        else {
            Console.WriteLine(num + " is not a multiple of 3");
        }
    }
}
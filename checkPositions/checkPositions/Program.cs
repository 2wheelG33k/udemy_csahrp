namespace checkPositions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the name for the first student: ");
        string studentName = Console.ReadLine();
        Console.WriteLine("Enter the score for " + studentName + ": ");
        int studentScore = int.Parse(Console.ReadLine());
        int studentPostition = PositionMethod(studentScore);
        Console.WriteLine(studentPostition);
        Print(studentName, studentPostition);
    }

    public static int PositionMethod(int number)
    {
        if (number < 50)
        {
            return 0;
        }
        else if (number >= 50 && number <= 60)
        {
            return 5;
        }
        else if (number >= 61 && number <= 70)
        {
            return 4;
        }
        else if (number >= 71 && number <= 80)
        {
            return 3;
        }
        else if (number >= 81 && number <= 90)
        {
            return 2;
        }
        else
        {
            return 1;
        }
    }

    public static void Print(string stdName, int position)
    {
        Console.WriteLine("Student Name is: " + stdName + " & Position is: " + position);
    }
}
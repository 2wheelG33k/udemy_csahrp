namespace starPyramid;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of rows for the pyramid: ");
        int pyramidHeight = int.Parse(Console.ReadLine());
        
        for (int i = 0; i <= pyramidHeight; i++)
        {
            int numStars = i;
            int numSpaces = (pyramidHeight - numStars) / 2;
            string printStars = "";
            for (int s = 0; s <= numSpaces; s++)
            {
                printStars += " ";
            }

            for (int p = 0; p <= numStars; p++)
            {
                printStars += "*";
            }
            Console.WriteLine(printStars);
        }
        
    }
}
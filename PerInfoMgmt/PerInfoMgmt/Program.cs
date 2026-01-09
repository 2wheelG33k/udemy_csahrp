namespace PerInfoMgmt;

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        
        Console.WriteLine("Enter name: ");
        person.Name = Console.ReadLine();
        
        Console.WriteLine("Enter age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        if (age > 0)
        {
            person.Age = age;
        }
        else
        {
            Console.WriteLine($"You entered an invalid age. Age set to 0."); 
            person.Age = 0;
        }
        
        Console.WriteLine("Enter address: ");
        person.Address = Console.ReadLine();
        
        Console.WriteLine("Enter position: ");
        person.Position = Console.ReadLine();
        
        Console.WriteLine("Enter department: ");
        person.Department = Console.ReadLine();
        
        Console.WriteLine("\nPerson Information: ");
        person.DisplayPersonInfo();
    }
}
namespace PerInfoMgmt;

public class Person
{
    private string _name;
    private int _age;
    private string _address;
    private string _position;
    private string _department;
    
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public int Age
    {
        get { return _age; }
        set
        {
            if (value >=0)
            {_age = value;}
            else
            { Console.WriteLine("Age must be greater than zero"); }
        }
    }
    public string Address
    {
        get { return _address; }
        set { _address = value; }
    }
    public string Position
    {
        get { return _position; }
        set { _position = value; }
    }
    public string Department
    {
        get { return _department; }
        set { _department = value; }
    }

    public void DisplayPersonInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}"); 
        Console.WriteLine($"Address: {Address}");
        Console.WriteLine($"Position: {Position}");
        Console.WriteLine($"Department: {Department}");
    }
}


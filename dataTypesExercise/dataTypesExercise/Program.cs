namespace dataTypesExercise;

class Program
{
    static void Main(string[] args)
    {
        byte variable_byte = 50;
        sbyte signedByteVariable = -50;
        short variable_short = -500;
        ushort unsignedShortVariable = 200;
        long variable_long = -5000;
        ulong unsignedLongVariable = 2000000000000000000UL;
        
        Console.WriteLine($"{variable_byte.GetType()} Byte: {variable_byte}");
        Console.WriteLine($"{signedByteVariable.GetType()} Sbyte: {signedByteVariable}");
        Console.WriteLine($"{variable_short.GetType()} Short: {variable_short}");
        Console.WriteLine($"{unsignedShortVariable.GetType()} Ushort: {unsignedShortVariable}");
        Console.WriteLine($"{variable_long.GetType()} Long: {variable_long}");
        Console.WriteLine($"{unsignedLongVariable.GetType()} Ulong: {unsignedLongVariable}");
    }
}
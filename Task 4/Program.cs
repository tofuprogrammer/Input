namespace Task_4;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        double firstUserNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter another number: ");
        double secondUserNumber = double.Parse(Console.ReadLine());
        Console.Write(firstUserNumber);
        Console.Write(" + ");
        Console.Write(secondUserNumber);
        Console.Write(" = ");
        double addition = firstUserNumber + secondUserNumber;
        Console.WriteLine(addition);
        Console.Write(firstUserNumber);
        Console.Write(" * ");
        Console.Write(secondUserNumber);
        Console.Write(" = ");
        double multiplication = firstUserNumber * secondUserNumber;
        Console.WriteLine(multiplication);
        Console.Write(secondUserNumber);
        Console.Write(" - ");
        Console.Write(firstUserNumber);
        Console.Write(" = ");
        double subtraction = secondUserNumber - firstUserNumber;
        Console.WriteLine(subtraction);
        if (secondUserNumber == 0)
        {
            Console.WriteLine("Error. Cannot divide by zero.");
        }
        else
        {
            Console.Write(firstUserNumber);
            Console.Write(" / ");
            Console.Write(secondUserNumber);
            Console.Write(" = ");
            double division = firstUserNumber / secondUserNumber;
            Console.WriteLine(division);
        }
    }
}
namespace Task_3;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the temperature in Celsius: ");
        double celsius = double.Parse(Console.ReadLine());
        double fahrenheit = (celsius * 1.8) + 32;
        double kelvin = celsius + 273.15;
        Console.Write(celsius);
        Console.Write(" Celsius is ");
        Console.Write(kelvin);
        Console.WriteLine(" Kelvin.");
        Console.Write(celsius);
        Console.Write(" Celsius is ");
        Console.Write(fahrenheit);
        Console.WriteLine(" Fahrenheit.");
    }
}
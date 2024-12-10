namespace Task_1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int firstUserNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter another number: ");
        int secondUserNumber = int.Parse(Console.ReadLine());
        Console.Write("The sum of your numbers is: ");
        int sum = firstUserNumber + secondUserNumber;
        Console.WriteLine(sum);
    }
}
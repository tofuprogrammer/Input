namespace Task_2;

class Program
{
    static void Main(string[] args)
    {
        int currentYear = DateTime.Now.Year;
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();
        Console.Write("Enter the year you were born: ");
        int userBirthYear = int.Parse(Console.ReadLine());
        Console.Write("Hello, ");
        Console.Write(userName);
        Console.Write("! You are ");
        int userAge = currentYear - userBirthYear;
        Console.Write(userAge);
        Console.WriteLine(" years old.");
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        // Call the methods to demonstrate their functionality
        string fullName = PromptUserName("first name", "last name");
        int favouriteNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(favouriteNumber);

        // Display welcome message and results
        DisplayWelcome();
        Console.WriteLine($"Hello, {fullName}.");
        Console.WriteLine($"The square of your number is: {squaredNumber}");

        // Method definitions
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program.");
        }
        
        static string PromptUserName(string firstName, string lastName)
        {
            Console.Write("Please enter your first name: ");
            string fName = Console.ReadLine();
            Console.Write("Please enter your last name: ");
            string lName = Console.ReadLine();
            return $"{fName} {lName}";
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter a number: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            return userNumber;
        }

        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }        
    }

}
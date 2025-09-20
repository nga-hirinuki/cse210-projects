using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");

        Console.Write("What is your first name? ");  // Prompt for first name
        string fname = Console.ReadLine();              // Read first name from user input  
        Console.Write("What is your last name? ");   // Prompt for last name
        string lname = Console.ReadLine();             // Read last name from user input
        // Output the formatted name
        Console.WriteLine($"Your name is {lname}, {fname} {lname}.");
    }
}
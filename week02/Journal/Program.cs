using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        // Create an instances for Journal and PromptGenerator
        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        Console.WriteLine("Welcome to the Journal Program!");

        // Declare variable for loop
        int choice = 0;

        // do loop to run choices
        do
        {
            // ask user to choice
            Console.WriteLine("Please select on of the following choices: ");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit ");
            Console.Write("What would you like to do?: ");

            //store answer and convert to int
            string number = Console.ReadLine();
            choice = int.Parse(number);

            //Conditional statement
            if (choice == 1)
            {
                // enter date
                Console.Write("Enter the date (e.g., day/date/month/year):");
                string date = Console.ReadLine();

                // get a prompt
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"{prompt}");

                //write response
                Console.Write("Enter your journal entry: ");
                string entryText = Console.ReadLine();

                Entry newEntry = new Entry
                {
                    _date = date,
                    _promptText = prompt,
                    _entryText = entryText,
                };

                // entry stored not saved to file yet
                myJournal.AddEntry(newEntry);
                Console.WriteLine("Entry successfully added");
            }
            else if (choice == 2)
            {
                //display all entries for this session
                Console.WriteLine("Display all your journal entries:");
                myJournal.DisplayAll();
            }
            else if (choice == 3)
            {
                // retrieve saved file
                Console.Write("Enter the filename to load( eg, journal.txt): ");
                string filename = Console.ReadLine();

                {
                    myJournal.LoadFromFile(filename);
                    Console.WriteLine($"Journal entries loaded from {filename}.");
                    myJournal.DisplayAll();
                }
            }
            else if (choice == 4)
            {
                // save file
                Console.Write("Enter filename to save ( eg, journal.txt): ");
                string fileName = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(fileName))
                {
                    Console.WriteLine("Invalid file name. Please try again.");
                }
                else
                {
                    myJournal.SaveToFile(fileName);
                    Console.WriteLine($"Journal entry is saved to {fileName}");
                    Console.WriteLine();
                }
            }
            else
            {
                //quit program
                Console.WriteLine("You have chosen to quit"); // quit program
            }

        } while (choice != 5);//guess until right
    }
}
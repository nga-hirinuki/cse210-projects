using System;

class Program
{
    static void Main(string[] args)
    {
        Reference verse = new Reference("Proverbs", 3, 5, 6); // pull in the reference of the scripture and next line the verses
        Scripture scripture = new Scripture(verse, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        scripture.HideRandomWords(0);
        Console.WriteLine(scripture.GetDisplayText()); // Start with no words hidden

        while (!scripture.IsCompletelyHidden()) // loops until all words are hidden
        
        {
            Console.WriteLine("\nPress Enter to hide 3 more words...");
            Console.ReadLine(); // Wait for user to press Enter

            scripture.HideRandomWords(3); // press enter until all words are 100% hidden

            Console.Clear(); // show one version of verses instead of multiples
            Console.WriteLine(scripture.GetDisplayText());
        }

        Console.WriteLine("\nAll words are hidden!");
    }
}
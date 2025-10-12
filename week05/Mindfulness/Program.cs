using System;

class Program
{
    static void Main(string[] args)
    {
        var choice = 0;
        
        do 
        {
            

            // Ask user to choice 
            Console.WriteLine("Menu Options: ");
            Console.WriteLine(" 1. Start Breathing activity");
            Console.WriteLine(" 2. Start Reflecting activity");
            Console.WriteLine(" 3. Start Listing activity");
            Console.WriteLine(" 4. Quit  ");
            Console.Write("Select a choice from the menu: "); 
            choice = int.Parse(Console.ReadLine());
            
            // Conditional statement 
            if (choice == 1) // Start Breathing activity
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();     
            }
            else if (choice == 2) // Start Reflecting activity
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
               
            }
            else if (choice == 3) // Start Listing activity
            {
               ListingActivity listingActivity = new ListingActivity();
               listingActivity.Run();
            }
            else
            {
                Console.WriteLine("You have chosen to quit"); //quit program
            }
        
        } while (choice != 4);//keep looping

    }
    
}
using System;

class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your grade? ");
            string userInput = Console.ReadLine();
            int x = int.Parse(userInput);

            if (x != 0 || userInput == "0")
            {
                if (x >= 90)
                {
                    Console.WriteLine("Your grade is an A");
                }
                else if (x >= 80)  
                {
                    Console.WriteLine("Your grade is a B");
                }
                else if (x >= 70)
                {
                    Console.WriteLine("Your grade is a C");
                }
                else if (x >= 60)
                {
                    Console.WriteLine("Your grade is a D");
                }
                else
                {
                    Console.WriteLine("You have failed");
                }
                        
               
            }
            
            
        }
    }

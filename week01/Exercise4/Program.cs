using System;

class Program
{
    static void Main(string[] args)
    {
        int input;
       
            List<int> numbers = new List<int> ();
            Console.WriteLine("Enter a list of numbers, type 0 when finished:");

        do
        {            
            Console.Write("Enter number: ");
            input = Convert.ToInt32(Console.ReadLine());

            if (input != 0)
            {
                numbers.Add(input);
            }
            else
            {
                int sum = 0;
                foreach (int number in numbers)
                {
                    sum += number;
                }
                Console.WriteLine("The sum is: " + sum);
                Console.WriteLine("The average is: " + (double)sum / numbers.Count);
                Console.WriteLine("The largest number is: " + numbers.Max());
                Console.WriteLine("The smallest number is: " + numbers.Min());
                Console.Write("The sorted list is: ");
                numbers.Sort();
                foreach (int number in numbers)
                {
                    Console.Write(number + " ");
                }
            }
        } while (input != 0); 
        
    }
}
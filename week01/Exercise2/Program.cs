using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        int x = 0;

        Console.Write("What is your score: ");
        x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Your grade is: ");

        if (x >= 90)
        {
            Console.Write("A");
        }
        else if (x >= 80)
        {
            Console.Write("B");
        }
        else if (x >= 70)
        {
            Console.Write("C");
        }
        else if (x >= 60)
        {
            Console.Write("D");
        }
        else
        {
            Console.Write("F");
        }

        int y = x % 10;

        if (x >= 97 && y >= 7)
        {
            Console.WriteLine("");
        }
        else if (x >= 87 && y >= 7)
        {
            Console.WriteLine("+");
        }
        else if (y <= 3)
        {
            Console.WriteLine("-");
        }
        else
        {
            Console.WriteLine();
        }

    }
}
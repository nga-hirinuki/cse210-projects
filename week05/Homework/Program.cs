using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment math = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(math.GetHomeworkList());

        WritingAssignment writing = new WritingAssignment("Jane Doe", "European History", "The Causes of World War II", "10/30/2024");
        Console.WriteLine(writing.GetWritingInfo());

        Assignment assignment = new Assignment("Samuel Bennet", "Multiplication");
        Console.WriteLine(assignment.GetSummary());

        Assignment assignment1 = new Assignment("Roberto Rodriguez", "Fractions");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment math1 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(math1.GetHomeworkList());
    }
}
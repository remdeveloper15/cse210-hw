using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment assignment1 = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8 - 19");
        WrittingAssignment assignment2 = new WrittingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine(assignment1.GetHomeworkList());
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetWrittingInformation());
    }
}
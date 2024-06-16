using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("Please Insert your percent grade un numbers: ");
        string grade = Console.ReadLine();
        int grade_int= int.Parse(grade);

        if (grade_int >= 90)
        {
            Console.WriteLine($"Your note is {grade_int}, which one is A in letters. Perfect grade!");
        }

        else if (grade_int >= 80)
        {
            Console.WriteLine($"Your note is {grade_int}, which one is B in letters. Excelent Job!");
        }

        else if (grade_int >= 70)
        {
            Console.WriteLine($"Your note is {grade_int}, which one is C in letters. Almost! but you need to practice more");
        }

        else if (grade_int >= 60)
        {
            Console.WriteLine($"Your note is {grade_int}, which one is D in letters. Sorry! Your grade is not enough");
        }

        else 
        {
            Console.WriteLine($"Your note is {grade_int}, which one is F in letters. I'm sorry! but you're lost ");
        }
    }
}
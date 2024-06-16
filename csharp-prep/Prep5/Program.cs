using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        Console.WriteLine("Aloha! ");
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        string square = SquareNumber(number);
        Displayresult(name, square);


        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!! ");

        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter you favorite number: ");
            string u_number = Console.ReadLine();
            int number = int.Parse(u_number);

            return number;
        }

        static string SquareNumber(int number)
        {
            int square_int = number * number;
            string square = square_int.ToString();
            
            return square;
        }
        
        static void Displayresult(string name, string square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }

    }
}
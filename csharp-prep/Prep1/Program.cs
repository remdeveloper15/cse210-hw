using System;

class Program
{
    static void Main(string[] args)
    {
        int x = 5;

        Console.WriteLine("Hello Prep1 World!");
        Console.WriteLine();

        Console.WriteLine("What is your name? ");
        string name = Console.ReadLine();    
        Console.WriteLine("What is your favorite color? ");
        string color = Console.ReadLine();
        Console.WriteLine("What is your favorite number? ");
        string number = Console.ReadLine();
        int fav = int.Parse(number);
        Console.WriteLine();

        if (fav < x)
        {
            string fail_message = $"Sorry {name}, your number is lower than {x} :c";
            Console.WriteLine(fail_message);   
        }

        else 
        {
            string success_message = "yay! you pass";
            Console.WriteLine("Yey! You pass! ");
            Console.WriteLine($"Hello {name}! Your favorite color is {color}, your favorite number is {number}. {success_message}");   
        }

        Console.WriteLine();

        Console.WriteLine("----------ASSIGNMENT------------");
        Console.Write("What is your first name? ");
        string name_1 = Console.ReadLine();
        Console.Write("What is your last name? ");
        string name_2 = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine($"Your name is {name_2}, {name_1} {name_2}");
    }
}
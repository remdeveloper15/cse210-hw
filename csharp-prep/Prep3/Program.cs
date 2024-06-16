using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        string response = "yes";
        string love = "";
        
        while (response == "yes")
        {
            Console.WriteLine("Do you want continue? ");
            response = Console.ReadLine();
            Console.WriteLine("Well, let's again...");
        }

            Console.WriteLine("Finally....");
        

        do
        {
            Console.Write("Do you love me? ");
            love = Console.ReadLine();
        } while (love != "yes");

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);

        Console.WriteLine(number);

        Console.WriteLine("---------------------------------------ASSIGNMENT-------------------------------------------");

        int magicNumber = 0;

        while (magicNumber != number)
        {
            
            Console.WriteLine("The magic number has been choseen...");
            Console.WriteLine("What is your guess? ");
            string semiMagicNumber = Console.ReadLine();
            magicNumber = int.Parse(semiMagicNumber);

            

            

            if (number < magicNumber)
            {
                Console.WriteLine("Lower");
            }

            else 
            {
                Console.WriteLine("Higher");
            }
        }

        Console.WriteLine("You guessed it! ");

    }

}
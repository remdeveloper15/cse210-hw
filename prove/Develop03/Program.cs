using System;

class Program
{
    static void Main(string[] args)
    {
        string userOption = "";

        while (userOption != "quit")
        {
            Reference reference1 = new Reference("Proverbs", 3, 5, 6);
            Word text1 = new Word("Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight");
            Console.Write(reference1.GetDisplayText());
            Console.WriteLine(text1.GetDisplayText());

            Console.WriteLine("");
            Console.WriteLine("Please enter to continue or type 'quit' to finish");
            userOption = Console.ReadLine();
            Console.Clear();

        }
        

    }
}
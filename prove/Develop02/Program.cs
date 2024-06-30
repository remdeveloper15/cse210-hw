using System;
using System.Reflection.Metadata;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int userOption = 0;
        Console.WriteLine("Welcome to the Journal Program!");

        PromptGenerator prompt = new PromptGenerator();
        Journal journal = new Journal();

        while (userOption != 5)
        {
        
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
        string userOptionString = Console.ReadLine();
        userOption = int.Parse(userOptionString); 

        if (userOption == 1)
        {
            string finalPrompt = prompt.GetRandomPrompt();
            Console.WriteLine(finalPrompt);
            Console.Write("> ");
            string entryUser = Console.ReadLine();
            DateTime theCurrentTime = DateTime.Now;
            string dateText = theCurrentTime.ToShortDateString();
            Entry entry = new Entry();


            entry._entryText = entryUser;
            entry._promptText = finalPrompt;
            entry._date = dateText;

            journal.AddEntry(entry);

        }

        else if (userOption == 2)
        {
            journal.DisplayAll();
        }

        else if (userOption == 4)
        {
            Console.Write("Please, enter the file name: ");
            string fileNameUser = Console.ReadLine();
            journal.SaveToFile(fileNameUser);
        }

        else if (userOption == 3)
        {
            Console.WriteLine("Please, enter the file that you want to load: ");
            string fileNameUser = Console.ReadLine();
            journal.LoadFromFile(fileNameUser);

        }

        }

        
    }
}
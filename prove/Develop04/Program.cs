using System;

class Program
{
    static void Main(string[] args)
    {
        int userOption = 0;
        Console.Clear();

        while (userOption != 4)
        {
            Console.WriteLine("-------MINDFULLNESS PROGRAM--------");
            Console.WriteLine("Menu Options");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflecting Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: "); 
            string userOptionString = Console.ReadLine();
            userOption = int.Parse(userOptionString);

            if (userOption == 1)
            {
                Console.Clear();
                BreathingActivity activity1 = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking yout through breahing in and out slowly. Clear your mind and focus on your breathing.");
                activity1.DisplayStartingMessage();
                activity1.Run();
                activity1.DisplayEndingMessage();   
            }

            else if (userOption == 2)
            {
                Console.Clear();
                ReflectingActivity activity2 = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strenght and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                activity2.DisplayStartingMessage();
                activity2.Run();
                activity2.DisplayEndingMessage();
            }

            else if(userOption == 3)
            {
                Console.Clear();
                ListingActivity activity3 = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a cerain area");
                activity3.DisplayStartingMessage();
                activity3.Run();
                activity3.DisplayEndingMessage();
            }
        }

        
    }
}
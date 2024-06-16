using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>();
        List<string> words = new List<string>();

        words.Add("miwa");
        words.Add("josh");
        words.Add("aiko");

        Console.WriteLine(words.Count);

        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

        for (int i = 0; i < words.Count; i++)
        {
            Console.WriteLine(words[i]);
        }
        

        List<int> numbersAssignment = new List<int>();

        int input = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        while (input != 0 )
        {
            Console.Write("Enter number: ");
            string inputUser = Console.ReadLine();
            input = int.Parse(inputUser);
            

            if (input != 0)
            {
                numbersAssignment.Add(input);
            }

        }

        
        int sum = 0;
        float  ave = 0;
        int max = 0;
        foreach (int number in numbersAssignment)
        {
            sum += number;
            
            if (number > max)
            {
                max = number;
            }
        }

        ave = ((float)sum) / numbersAssignment.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The avareage is: {ave}");
        Console.WriteLine($"The largest is: {max}");
    }
}
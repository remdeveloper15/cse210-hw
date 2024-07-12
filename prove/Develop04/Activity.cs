public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine("");
        Console.WriteLine(_description);
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like for your session? ");
        string durationString = Console.ReadLine();
        _duration = int.Parse(durationString); 
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Well done!");
        ShowSpinner(500);
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");
        ShowSpinner(500);
        Console.Clear(); 
    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinner = new List<string>(); 
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("—");
        spinner.Add("\\");
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");


        foreach (string s in spinner)
        {
            Console.Write(s);
            Thread.Sleep(seconds);
            Console.Write("\b \b");
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    }
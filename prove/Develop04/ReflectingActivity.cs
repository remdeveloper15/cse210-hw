public class ReflectingActivity : Activity
{
    private List<string> _questions = new List<string>() {"How did you feel when it was complete? ", "What is your favorite thing about this experience?", "What did you learn from this experience", "In a scale from 1 to 10, How much hard it was for you? "};
    private List<string> _prompts = new List<string>() {"Think of a time when you did somehting really difficult", "Think about one situation that had made you feel anxiety", "Think about one time when you did a correct thing even when it didn't something good for you"}; 

    
    public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
    {
    }

    public ReflectingActivity(string name, string description) : base(name, description)
    {
        
    }

    public void Run()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        
        Console.Clear();
        Console.WriteLine("Get Ready.....");
        ShowSpinner(5);
        Console.WriteLine("");

        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine("");
        DisplayPrompt();
        Console.WriteLine("");
        Console.Write("When you have something in mind, press enter to contine.");
        Console.ReadLine(); 
        Console.WriteLine("");
        Console.Write("Now ponder each of the following questions as they related to this experience: ");
        ShowCountDown(5);
        Console.Clear();

        while (DateTime.Now < endTime )
        {
            DisplayQuestions();
            ShowSpinner(1000);
        }
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();

        int index = random.Next(_prompts.Count);
        string finalPrompt = _prompts[index];
        return "---" + finalPrompt + "---"; 
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();

        int index = random.Next(_questions.Count);
        string finalQuestion = _questions[index];
        return "> " + finalQuestion;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }

    public void DisplayQuestions()
    {
        Console.WriteLine(GetRandomQuestion());
    }
}
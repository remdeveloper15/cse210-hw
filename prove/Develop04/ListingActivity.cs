public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>() {"When have you felt the Holy Ghost this month? ", "When do you feel blessed in this week?", "There is one person that you have to contact? ", "Lists things that you think you improve"};



     public ListingActivity(string name, string description) : base(name, description)
    {
    }
    List<string> _list = new List<string>();
    public void Run()
    {
        
        _count = 0;
        Console.Clear();
        Console.WriteLine("Get Ready.....");
        ShowSpinner(500);
        Console.WriteLine("");
        Console.WriteLine("");
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        Console.WriteLine("List as many responses you can to the following prompt: ");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine("");

        while (DateTime.Now < endTime )
        {
            
            Console.Write("> ");
            string answer = Console.ReadLine();
            _list.Add(answer);
            
            
        }
        
        foreach(string i in _list)
        {
            _count = _count + 1;
        }

        Console.WriteLine("");
        Console.WriteLine($"You listed {_count} items!");    
    }

    public void GetRandomPrompt()
    {
         Random random = new Random();
         int index = random.Next(_prompts.Count);
         string finalPrompt = _prompts[index];
         Console.WriteLine("--- " + finalPrompt + " ---");
    }

    public List<string> GetListFromUser()
    {
        return _list;
    }
}
public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
    }

    public BreathingActivity(string name, string description) : base(name, description)
    {
    }
    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Get Ready.....");
        ShowSpinner(500);
        Console.WriteLine("");
        Console.WriteLine("");
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime )
        {
            Console.WriteLine("");
            Console.Write("Breath in....");
            ShowCountDown(_duration);
            Console.WriteLine("");
            Console.Write("Now breathe out...");
            ShowCountDown(_duration);
            Console.WriteLine("");
            
        }
    }
}
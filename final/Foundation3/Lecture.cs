public class Lecture : Event
{
    private string _capacity;
    private string _speaker; 
    
    public Lecture(string titlte, string description, string date, string time, string address, string capacity, string speaker) : base(titlte, description, date, time, address)
    {
        _capacity = capacity;
        _speaker = speaker;
    }

    public void DisplayFullDetail()
    {
        Console.WriteLine("");
        Console.WriteLine($"--------------------------------------------------------EXTRA LECTURE EVENT DETAILS----------------------------------------------------------");
        Console.WriteLine("");
        Console.WriteLine($"SPEAKER: {_speaker}");
        Console.WriteLine($"OWN SPEAKER: We count with our defalut Speaker: {_speaker}. If you have your own Speaker, please let us know.");
        Console.WriteLine($"CAPACITY: {_capacity} persons");
        
    }
}
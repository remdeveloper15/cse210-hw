public class OutdoorGathering : Event
{
    private string _weather;
    public OutdoorGathering(string titlte, string description, string date, string time, string address,string weather) : base(titlte, description, date, time, address)
    {
        _weather = weather;
    }

    public void DisplayFullDetail()
    {
        Console.WriteLine("");
        Console.WriteLine($"--------------------------------------------------------EXTRA OUTDOOR GATHERING EVENT DETAILS----------------------------------------------------------");
        Console.WriteLine("");
        Console.WriteLine($"STATEMENT OF WEATHER: {_weather}");
    }
}
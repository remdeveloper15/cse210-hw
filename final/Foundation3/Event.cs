public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private string _address;

    public Event(string titlte, string description, string date, string time, string address)
    {
        _title = titlte;
        _description = description;
        _date = date;
        _time = time; 
        _address = address;
    }

    public void DisplayStandardDetails()
    {
        Console.WriteLine("");
        Console.WriteLine($"--------------------------------------------------------{_title} EVENT----------------------------------------------------------");
        Console.WriteLine("");
        Console.WriteLine($"DESCRIPTION: {_description}");
        Console.WriteLine($"DATE: {_date}");
        Console.WriteLine("NOTE: If you want to planning this kind of event in a day that isn't avaible, you can call to +593 0980857365, in order to reserve a day that is not in the shecdule.");
        Console.WriteLine($"TIME: {_time}");
        Console.WriteLine($"ADDRESS: {_address}");   
    }

    public void DisplayShortDescription()
    {
        Console.WriteLine("");
        Console.WriteLine($"--------------------------------------------------------{_title} EVENT SHORT DESCRIPTION----------------------------------------------------------");
        Console.WriteLine($"");
        Console.WriteLine($"KIND OF EVENT: {_title}");
        Console.WriteLine($"DATE: {_date}");
    }

    

}
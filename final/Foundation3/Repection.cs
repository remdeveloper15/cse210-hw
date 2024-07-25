public class Reception : Event
{
    private string _email;
    public Reception(string titlte, string description, string date, string time, string address, string email) : base(titlte, description, date, time, address)
    {
        _email = email;
    }

    public void DisplayFullDetail()
    {
        Console.WriteLine("");
        Console.WriteLine($"--------------------------------------------------------EXTRA RECEPTION EVENT DETAILS----------------------------------------------------------");
        Console.WriteLine("");
        Console.WriteLine("RECEPTIONS: You can make your RSVP texting to the following email address - helamanfranco@hotmail.com");
    }
}
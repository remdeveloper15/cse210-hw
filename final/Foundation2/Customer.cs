public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }


    public void DisplayCustomer()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Address: {_address.GetAddress()}");
    }

}
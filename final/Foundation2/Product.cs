public class Product
{
    private string _productName;
    private string _id;
    private double _price;
    private double _quantity;

    public Product(string productName, string id, double price, double quantity)
    {
        _productName = productName;
        _id = id;
        _price = price;
        _quantity = quantity;
    }


    public string GetProduct()
    {
        return $"{_productName}, {_id}, ${_price}, {_quantity} units";
    }

    public double GetTotalCost()
    {
        double _total = _quantity * _price;
        return _total;
    }

    public void GetProductPackingLabel()
    {
        Console.WriteLine($"Product: {_productName}, ID number:{_id}");
    }
}
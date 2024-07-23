using System.Runtime.InteropServices;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    private Product _product;
    private double _total;
    private double _shipping = 5.00;

    public Order(Customer customer, Product product)
    {
        _customer = customer;
        _product = product;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public void TotalCostOrder()
    {
        Console.WriteLine("");
        Console.WriteLine("Total: ");
        Console.WriteLine("");
        
        
        foreach (Product product in _products)
        {
            _total += product.GetTotalCost();        
        }

        Console.WriteLine($"Your total is: ${Math.Round(_total, 2)} dollars");

        Console.WriteLine("----------------------------------------------ORDER TOTAL COST---------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine($"Total Order Cost:    ${Math.Round(_total, 2)}");
            Console.WriteLine($"Shipping Cost:       ${_shipping}");
            Console.WriteLine($"Final Cost:          ${Math.Round(_total + _shipping, 2)}");     

        
    }

    public void GetProcess()
    {
            int count = 0;
            Console.WriteLine("--------------------------------------------------ORDER------------------------------------------------------");
            Console.WriteLine("");
            _customer.DisplayCustomer();
            Console.WriteLine("");
            Console.WriteLine("Products: ");
            Console.WriteLine("");

            foreach (Product product in _products)
            {
                count += 1;
                Console.Write($"{count}. ");
                Console.WriteLine(product.GetProduct());
            }
            


    }

    public void GetPackingLabel()
    {
        int count = 0;
        Console.WriteLine("--------------------------------------------------PACKING LABEL-----------------------------------------------");
        Console.WriteLine("");
        Console.WriteLine("Products: ");
        Console.WriteLine("");
        
        foreach (Product product in _products)
        {
            count += 1;
            Console.Write($"{count}. ");
            product.GetProductPackingLabel();
        }

        Console.WriteLine("");
        Console.WriteLine($"Total amount of articles: {count}");
    }

    public void GetShippingLabel()
    {

        Console.WriteLine("--------------------------------------------------SHIPPING LABEL-----------------------------------------------");
        Console.WriteLine("");
        _customer.DisplayCustomer();
         Console.WriteLine("");

    }
}
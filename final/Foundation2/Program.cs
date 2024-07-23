using System;

class Program
{
    static void Main(string[] args)
    {
        
        List<Order> _orders = new List<Order>();
        Address address = new Address("410, Main Street", "Albany", "New York", "United States of America");
        
        Customer customer = new Customer("Orlando Franco", address);

        Product product11 = new Product("One litter Milk", "101112", 1.09, 3);
        Product product12 = new Product("Bread", "101113", 0.89, 2);
        Product product13 = new Product("Gun", "101114", 30.15, 1);

        Address address1 = new Address("185, Continental Divide Trail", "Santa Fe", "Nuevo Mexico", "United State Of America");

        Customer customer1 = new Customer("Timmy Turner", address1);

        Product product21 = new Product("Magic Dove", "458264", 20.52, 2);
        Product product22 = new Product("Magic Wand", "201232", 500.02, 1);
        Product product23 = new Product("Crytonite", "189246", 70.28, 4);
        Product product24 = new Product("Theeth", "205252", 4.58, 2);

        Order order = new Order(customer, product11);
        Order order1 = new Order(customer1, product21);

        _orders.Add(order);
        _orders.Add(order1);
        
        order.AddProduct(product11);
        order.AddProduct(product12);
        order.AddProduct(product13);
        order1.AddProduct(product21);
        order1.AddProduct(product22);
        order1.AddProduct(product23);
        order1.AddProduct(product24);

        foreach (Order o in _orders)
        {
            o.GetProcess();
            o.TotalCostOrder();
            o.GetPackingLabel();
            o.GetShippingLabel();
        }
        

       

    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Address addr = new Address("123 Apple St", "New York", "NY", "USA");
        Customer cust = new Customer("John Doe", addr);

        Order order = new Order(cust);

        //string name, int ID, double price, int quantity
        Product p1 = new Product("Keyboard", 123, 50.00, 1);
        Product p2 = new Product("Mouse", 400, 25.00, 2);

        order.AddProduct(p1);
        order.AddProduct(p2);

        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"\nTOTAL PRICE: ${order.GetTotalPrice()}");
    }
}
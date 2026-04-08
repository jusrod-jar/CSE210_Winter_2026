using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("956 Maple Boulevard", "Wesley Chapel", "FL", "USA");
        Address address2 = new Address("9 Moose Drive", "Toronto", "ON", "Canada");

        Customer customer1 = new Customer("James Hamilton", address1);
        Customer customer2 = new Customer("Anek Orozco", address2);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "LPT-99", 800, 1));
        order1.AddProduct(new Product("Gaming Mouse", "MS-02", 20, 2));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Keyboard", "KB-55", 50, 1));
        order2.AddProduct(new Product("Monitor", "MN-12", 200, 2));
        order2.AddProduct(new Product("HDMI Cable", "CBL-01", 10, 3));

        Console.WriteLine();
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"\n{order1.GetPackingLabel()}");
        Console.WriteLine($"Total: {order1.CalculateTotalPrice()}\n");

        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"\n{order2.GetPackingLabel()}");
        Console.WriteLine($"Total: {order2.CalculateTotalPrice()}\n");

    }
}
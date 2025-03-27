using System;

class Program
{
    static void Main()
    {
        // Address Customer 1 (Lives in Springfield)
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");

        // Customer 1
        Customer customer1 = new Customer("John Doe", address1);

        // Customer 1's Order
        Product product1 = new Product("Laptop", 101, 1000, 1);
        Product product2 = new Product("Mouse", 102, 25, 2);

        // Order for Customer 1 and add products
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        // Display Packing Label, Shipping Label, and Total Cost 
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price for Order 1 (after discount): ${order1.CalculateTotalCost()}");

        // Address Customer 2 (Lives in Toronto)
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");

        // Customer 2
        Customer customer2 = new Customer("Jane Smith", address2);

        // Products for Customer 2's Order
        Product product3 = new Product("Phone", 103, 500, 1);
        Product product4 = new Product("Charger", 104, 15, 1);

        // Order for Customer 2 and add products
        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // Display Packing Label, Shipping Label, and Total Cost 
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price for Order 2 (after discount): ${order2.CalculateTotalCost()}");
    }
}

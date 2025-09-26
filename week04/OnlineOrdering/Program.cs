using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a customer from USA 
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("Nas", address1);

        // Create an order for the customer
        Order order1 = new Order(customer1);

        // Create products
        Product product1 = new Product("Laptop", "P001", 1200.00, 1);
        Product product2 = new Product("Mouse", "P002", 25.00, 2);
        Product product3 = new Product("Keyboard", "P003", 45.00, 1);

        // Add products to the order
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        // Display order details
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}");

        // Create a customer from outside USA
        Address address2 = new Address("456 Hlangabeza St", "Bulawayo", "BYO", "ZIM"); 
        Customer customer2 = new Customer("Hova", address2);

        // Create an order for the customer
        Order order2 = new Order(customer2);

        // Create products
        Product product4 = new Product("PlayStation", "P004", 1800.00, 1);
        Product product5 = new Product("Console", "P005", 75.00, 2);
        Product product6 = new Product("Oled Tv", "P006", 800.00, 1);

        // Add products to the order
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);

        // Display order details
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");        
    }
}
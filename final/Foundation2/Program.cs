using System;

class Program
{
    static void Main(string[] args)
    {
        // Create Order 1 (USA)
        Address address1 = new Address("123 Maple St", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("John Smith", address1);
        Order order1 = new Order(customer1);

        Product p1 = new Product("Laptop", "L100", 800.00, 1);
        Product p2 = new Product("Mouse", "M200", 25.00, 2);

        order1.AddProduct(p1);
        order1.AddProduct(p2);

        // Create Order 2 (International)
        Address address2 = new Address("789 Rue de Rivoli", "Paris", "IDF", "France");
        Customer customer2 = new Customer("Marie Curie", address2);
        Order order2 = new Order(customer2);

        Product p3 = new Product("Science Book", "B500", 45.00, 3);
        Product p4 = new Product("Pen", "P001", 1.50, 10);

        order2.AddProduct(p3);
        order2.AddProduct(p4);

        // Display Order 1 results
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("TOTAL PRICE: $" + order1.CalculateTotalCost());
        Console.WriteLine();

        // Display Order 2 results
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("TOTAL PRICE: $" + order2.CalculateTotalCost());
    }
}
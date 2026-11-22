using System;

class Program
{
    static void Main(string[] args)
    {
        // Create the first customer's address (Nigeria)
        Address address1 = new Address(
            "15 Airport Road",
            "Ikeja",
            "Lagos State",
            "Nigeria"
        );

        Customer customer1 = new Customer("Patrick Osakwe", address1);

        // Create products for the first order
        Product product1 = new Product("Laptop", "L101", 850.00, 1);
        Product product2 = new Product("Mouse", "M102", 25.00, 2);
        Product product3 = new Product("Keyboard", "K103", 45.00, 1);

        // Create first order and add products
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        // Create the second customer's address (NIGERIA)
        Address address2 = new Address(
            "25 Byazhin Street",
            "Kubwa",
            "Abuja",
            "Nigeria"
        );

        Customer customer2 = new Customer("Joy Agukwu", address2);

        // Create products for the second order
        Product product4 = new Product("Headphones", "H201", 60.00, 2);
        Product product5 = new Product("Smart Watch", "S202", 120.00, 1);
        Product product6 = new Product("Tablet", "T203", 300.00, 1);

        // Add products and Create second order
        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);

        // Display first order
        Console.WriteLine("========== ORDER 1 ==========");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: NGN {order1.GetTotalCost():N2}");
        Console.WriteLine();

        // Display second order
        Console.WriteLine("========== ORDER 2 ==========");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: NGN {order2.GetTotalCost():N2}");
    }
}
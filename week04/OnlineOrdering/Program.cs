using System;

class Program
{
    static void Main(string[] args)
    {
        var product1 = new Product("T-shirt", 20.00, 101, 2); // $40
        var product2 = new Product("Mug", 10.00, 102, 1);     // $10

        var address = new Address("123 Main St", "New York", "NY", "USA");
        var customer = new Customer("Alice", address);
        var order = new Order(customer);
        
        order.AddProduct(product1);
        order.AddProduct(product2);

        Console.WriteLine($"\nTotal Cost: ${order.GetTotalCost():F2}"); // Should be $55.00
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine();
        

        var product3 = new Product("Hoodie", 65.00, 501, 4); // $260
        var product4 = new Product("T-shirt", 15.00, 102, 6);     // $90

        var address1 = new Address("123 Bridge St", "Tokoroa", "Waikato", "NZ");
        var customer1 = new Customer("Tane", address1);
        var order1 = new Order(customer1);

        order1.AddProduct(product3);
        order1.AddProduct(product4);

        Console.WriteLine($"\nTotal Cost: ${order1.GetTotalCost():F2}"); // Should be $385.00
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();

        var product5 = new Product("Cargo Shorts", 25.00, 322, 2); // $50
        var product6 = new Product("Socks", 7.00, 753, 3);     // $21

        var address2 = new Address("123 Henderson St", "Mt Roskill", "Auckland", "NZ");
        var customer2 = new Customer("Maggie", address2);
        var order2 = new Order(customer2);

        order2.AddProduct(product5);
        order2.AddProduct(product6);

        Console.WriteLine($"\nTotal Cost: ${order2.GetTotalCost():F2}"); // Should be $106.00
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();

    }
}

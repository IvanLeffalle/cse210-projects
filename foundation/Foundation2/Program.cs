using System;

class Program
{
    static void Main(string[] args)
    {
        Customer newCustomer = new Customer("Ivan Leffalle", new Address("123 Main St", "St. George", "CA", "USA"));

        Product product1 = new Product("iPhone X", 999.99, 1, 1);
        Product product2 = new Product("MacBook Pro", 1299.99, 1, 2);
        Product product3 = new Product("iPad", 499.99, 2, 3);

        Order newOrder = new Order(newCustomer, new List<Product> { product1, product2, product3 });

        Console.WriteLine("*****************************************");
        Console.WriteLine(newOrder.GetPackingLabel());
        Console.WriteLine("*****************************************"); Console.WriteLine($"Products Price: ${newOrder.GetProductsPrice()}");
        Console.WriteLine($"Shipping Cost: ${newOrder.GetShippingCost()}");
        Console.WriteLine($"Total Price: ${newOrder.GetTotalPrice()}");
        Console.WriteLine($"Shipping Label: {newOrder.GetShippingLabel()}");

        Customer newCustomer2 = new Customer("Gonzalo Leffalle", new Address("1234 Main St", "Resistencia", "Chaco", "Argentina"));
        Product customer2Product1 = new Product("Samsung Galaxy S10", 999.99, 1, 4);
        Product customer2Product2 = new Product("Samsung Galaxy S20", 1299.99, 1, 5);
        Product customer2Product3 = new Product("Samsung Galaxy S30", 499.99, 2, 6);

        Order newOrder2 = new Order(newCustomer2, new List<Product> { customer2Product1, customer2Product2, customer2Product3 });

        Console.WriteLine("*****************************************");
        Console.WriteLine(newOrder2.GetPackingLabel());
        Console.WriteLine("*****************************************"); Console.WriteLine($"Products Price: ${newOrder2.GetProductsPrice()}");
        Console.WriteLine($"Shipping Cost: ${newOrder2.GetShippingCost()}");
        Console.WriteLine($"Total Price: ${newOrder2.GetTotalPrice()}");
        Console.WriteLine($"Shipping Label: {newOrder2.GetShippingLabel()}");
    }
}
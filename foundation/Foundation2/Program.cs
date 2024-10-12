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


    }
}
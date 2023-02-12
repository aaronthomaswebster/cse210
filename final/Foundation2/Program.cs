using System;

class Program
{
    static void Main(string[] args)
    {
        Customer Tom = new Customer("Tom", new Address("123 Main St", "New York", "NY", "US"));
        Customer Bob = new Customer("Bob", new Address("456 Lesser Dr", "Winnipeg", "MB", "CA"));

        Order TomOrder = new Order(Tom);
        Order BobOrder = new Order(Bob);

        Product p1 = new Product("Shirt", "10", 799, 2);
        Product p2 = new Product("Pants", "11", 999, 1);
        TomOrder.AddProduct(p1);
        TomOrder.AddProduct(p2);

        Product p4 = new Product("Shirt", "10", 799, 2);
        Product p5 = new Product("Pants", "11", 999, 1);
        Product p6 = new Product("Shoes", "12", 1299, 1);
        BobOrder.AddProduct(p4);
        BobOrder.AddProduct(p5);
        BobOrder.AddProduct(p6);
        Console.WriteLine();        
        Console.WriteLine();


        Console.WriteLine("Tom's Order:");
        Console.WriteLine(TomOrder.PackingLabel());      
        Console.WriteLine();        
        Console.WriteLine(TomOrder.ShippingLabel());
        Console.WriteLine();
        Console.WriteLine("Total Price: {0:C}", TomOrder.TotalPrice());
        Console.WriteLine();        
        Console.WriteLine();

        Console.WriteLine("Bob's Order:");
        Console.WriteLine(BobOrder.PackingLabel());      
        Console.WriteLine();        
        Console.WriteLine(BobOrder.ShippingLabel());
        Console.WriteLine();        
        Console.WriteLine("Total Price: {0:C}", BobOrder.TotalPrice());



    }
}
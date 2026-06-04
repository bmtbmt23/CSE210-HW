using System;
class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address(
            "50 W North Temple St",
            "Salt Lake City",
            "UT",
            "USA"
        );
        
        Customer customer1 = new Customer("Barbara Reys", address1);
        
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Woman Nike Shoes", "Size 8", 200.00, 1));
        order1.AddProduct(new Product("Man Nike Shoes", "Size 10", 280.00, 1));
        order1.AddProduct(new Product("Woman Sandals", "Size 8.5", 150.00, 1));
        order1.AddProduct(new Product("Man Sandals", "Size 10.5", 120.00, 2));
        
        
        Address address2 = new Address(
            "3074 Porto Avenue",
            "Canada",
            "CAN",
            "Canada"
        );
        
        Customer customer2 = new Customer("Ana Santos", address2);
        
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Book of Mormon", "", 18.00, 2));
        order2.AddProduct(new Product("Bible", "", 20.00, 3));
        order2.AddProduct(new Product("Pencils", "", 5.00, 1));
        
        
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: $(Order1.GetTotalPrice():N2)");
        Console.WriteLine("\n--------------------------------------\n");
        Console.WriteLine($"Thank You {customer1.GetName} For Shopping With Us!");
        
        Console.WriteLine("\n--------------------------------------\n");
        
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: $(Order2.GetTotalPrice():N2)");
        Console.WriteLine("\n--------------------------------------\n");
        Console.WriteLine($"Thank You {customer2.GetName} For Shopping With Us!");
    
        
    }

}
using Sytem;
class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address{
            "50 W North Temple St",
            "Salt Lake City",
            "UT",
            "USA",
        };
        
        Customer customer1 = new Customer("Barbara Reys", address1);
        
        Order order1 = new Order(customer1);
        Order1.AddProduct(new Product("Woman Nike Shoes", "Size 8", 200.00m, 1));
        Order1.AddProduct(new Product("Man Nike Shoes", "Size 10", 280.00m, 1));
        Order1.AddProduct(new Product("Woman Sandals" "Size 8.5", 150.00m, 1));
        Order1.AddProduct(new Product("Man Sandals" "Size 10.5", 120.00m, 2));
        
        
        Address address2 = new Address{
            "3074 Porto Avenue",
            "Canada",
            "CAN",
            "Canda",
        };
        
        Customer customer2 = new Customer("Ana Santos", address2);
        
        Order order2 = new Order(Customer2);
        Order2.AddProduct(new Product("Book of Mormon", 18.00m, 2));
        Order2.AddProduct(new Product("Bible", 20.00m, 3));
        Order2.AddProdct(new Product("Pencils", 5.00m, 1));
        
        
        Console.WriteLine(Order1.GetPackingLabel());
        Console.WriteLine(Order1.GetShippingLabel());
        Console.WriteLine($"Total Price: $(Order1.GetTotalPrice():N2)");
        Console.WriteLine("\n--------------------------------------\n");
        Console.WriteLine($"Thank You {customer1.Name} For Shopping With Us!");
        
        Console.WriteLine("\n--------------------------------------\n");
        
        Console.WriteLine(Order2.GetPackingLabel());
        Console.WriteLine(Order2.GetShippingLabel());
        Console.WriteLine($"Total Price: $(Order2.GetTotalPrice():N2)");
        Console.WriteLine("\n--------------------------------------\n");
        Console.WriteLine($"Thank You {customer2.Name} For Shopping With Us!");
    
        
    }

}
using System.Text;

class Program
{
    static void Main()
    {
        // Create an address
        Address address = new Address
        {
            Street = "123 Main St",
            City = "Anytown",
            State = "CA",
            Country = "USA"
        };

        // Create a customer
        Customer customer = new Customer
        {
            Name = "John Doe",
            Address = address
        };

        // Create a product
        Product product1 = new Product
        {
            Name = "Example Product",
            Id = 1,
            PricePerUnit = 10,
            Quantity = 3
        };

        // Create another product
        Product product2 = new Product
        {
            Name = "Another Product",
            Id = 2,
            PricePerUnit = 5,
            Quantity = 2
        };

        // Create an order
        Order order = new Order(customer);
        order.AddProduct(product1);
        order.AddProduct(product1);
        order.AddProduct(product2);

        // Calculate total cost
        decimal totalCost = order.CalculateTotalCost();
        Console.WriteLine($"Total cost of the order: {totalCost:C}");

        // Get packing label
        string packingLabel = order.GetPackingLabel();
        Console.WriteLine("Packing Label:");
        Console.WriteLine(packingLabel);

        // Get shipping label
        string shippingLabel = order.GetShippingLabel();
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(shippingLabel);
    }
}


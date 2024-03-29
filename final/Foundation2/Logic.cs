using System.Text;

public class Order
{
    private List<Product> products;
    private Customer customer;
    
    public Order(Customer customer)
    {
        this.products = new List<Product>();
        this.customer = customer;
    }
    
    public void AddProduct(Product product)
    {
        products.Add(product);
    }
    
    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;
        foreach (var product in products)
        {
            totalCost += product.CalculateTotalCost();
        }
        if (customer.IsInUSA())
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }
        return totalCost;
    }
    
    public string GetPackingLabel()
    {
        StringBuilder label = new StringBuilder();
        foreach (var product in products)
        {
            label.AppendLine($"Name: {product.Name}, Product ID: {product.Id}");
        }
        return label.ToString();
    }
    
    public string GetShippingLabel()
    {
        return customer.GetShippingAddress();
    }
}

public class Product
{
    public string Name { get; set; }
    public int Id { get; set; }
    public decimal PricePerUnit { get; set; }
    public int Quantity { get; set; }
    
    public decimal CalculateTotalCost()
    {
        return PricePerUnit * Quantity;
    }
}

public class Customer
{
    public string Name { get; set; }
    public Address Address { get; set; }
    
    public bool IsInUSA()
    {
        return Address.IsInUSA();
    }
    
    public string GetShippingAddress()
    {
        return Address.ToString();
    }
}

public class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    
    public bool IsInUSA()
    {
        return Country.ToLower() == "usa";
    }
    
    public override string ToString()
    {
        return $"Name: {Street}\nCity: {City}\nState: {State}\nCountry: {Country}";
    }
}
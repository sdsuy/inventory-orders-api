namespace Inventory.Domain.Entities;

public class Product
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public decimal Price { get; private set; }
    public int Stock { get; private set; }
    public bool IsActive { get; private set; }

    public Product(string name, decimal price, int stock)
    {
        Id = Guid.NewGuid();
        Name = name;
        Price = price;
        Stock = stock;
        IsActive = true;
    }
    
    public void UpdateStock(int quantity)
    {
        Stock += quantity;
    }

    public void Deactivate()
    {
        IsActive = false;
    }
}

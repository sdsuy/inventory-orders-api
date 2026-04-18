namespace Inventory.Domain.Entities;

public class OrderItem
{
    public Guid Id { get; private set; }
    public Guid ProdcutId { get; private set; }
    public int Quantity { get; private set; }
    public decimal UnitPrice { get; private set; }
    
    private OrderItem()
    {
    }

    public OrderItem(Guid productId, int quantity, decimal unitPrice)
    {
        Id = Guid.NewGuid();
        ProdcutId = productId;
        Quantity = quantity;
        UnitPrice = unitPrice;
    }
}

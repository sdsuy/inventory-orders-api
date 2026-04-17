namespace Inventory.Domain.Entities;

public class OrderItem
{
    public Guid ProdcutId { get; private set; }
    public int Quantity { get; private set; }
    public decimal UnitPrice { get; private set; }

    public OrderItem(Guid productId, int quantity, decimal unitPrice)
    {
        ProdcutId = productId;
        Quantity = quantity;
        UnitPrice = unitPrice;
    }
}

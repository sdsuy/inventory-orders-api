using Inventory.Domain.Enums;

namespace Inventory.Domain.Entities;

public class StockMovement
{
    public Guid Id { get; private set; }
    public Guid ProductId { get; private set; }
    public int Quantity { get; private set; }
    public StockMovementType Type { get; private set; }
    public DateTime CreatedAt { get; private set; }

    public StockMovement(Guid productId, int quantity, StockMovementType type)
    {
        Id = Guid.NewGuid();
        ProductId = productId;
        Quantity = quantity;
        Type = type;
        CreatedAt = DateTime.UtcNow;
    }
}

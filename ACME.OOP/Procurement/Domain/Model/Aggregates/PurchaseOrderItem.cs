namespace ACME.OOP.Procurement.Domain.Model.Aggregates;

using ACME.OOP.Procurement.Domain.Model.ValueObjects;
using ACME.OOP.Shared.Domain.Model.ValueObjects;

public class PurchaseOrderItem(ProductId productId, int quantity, Money unitPrice)
{
    public ProductId ProductId { get; } = productId ?? throw new ArgumentNullException(nameof(productId));
    public int Quantity { get; } = quantity < 0 ? throw new ArgumentOutOfRangeException(nameof(quantity)) : quantity;
    public Money UnitPrice { get; } = unitPrice ?? throw new ArgumentNullException(nameof(unitPrice));

    public Money CalculateSubtotal() => new Money(Quantity * UnitPrice.Amount, UnitPrice.Currency);
}
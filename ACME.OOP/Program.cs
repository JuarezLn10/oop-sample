using ACME.OOP.SCM.Domain.Model.Aggregates;
using ACME.OOP.Shared.Domain.Model.ValueObjects;
using ACME.OOP.Procurement.Domain.Model.Aggregates;
using ACME.OOP.Procurement.Domain.Model.ValueObjects;
using ACME.OOP.SCM.Domain.Model.ValueObjects;

// Create a new Supplier object
var supplierAddress = new Address("123 Main St", "12345", "New York", "New York", "NY", "USA");
var supplier = new Supplier("SUP0001", "Microsoft, Inc.", supplierAddress);

// Create a new PurchaseOrder object
var purchaseOrder = new PurchaseOrder("PO0001", new SupplierId(supplier.Identifier), "USD");
purchaseOrder.AddItem(ProductId.New(), 10, 25.99m);
purchaseOrder.AddItem(ProductId.New(), 5, 15.99m);

// Display the purchase order details
Console.WriteLine($"Purchase Order ID: {purchaseOrder.OrderNumber} created on {purchaseOrder.OrderDate} for supplier {supplier.Name}");
foreach (var item in purchaseOrder.Items)
{
    var itemSubtotal = item.CalculateSubtotal();
    Console.WriteLine($"Item Subtotal: {itemSubtotal.AsString()}");
}

var total = purchaseOrder.CalculateTotal();
Console.WriteLine($"Total: {total.AsString()}");
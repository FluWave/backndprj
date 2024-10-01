using System;

namespace TechZone.Entities.Concrete;

public class BuyerItem
{
    public int Id { get; set; }
    public int BuyerId { get; set; }
    public Buyer Buyer { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}

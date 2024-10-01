using System;
using TechZone.Entities.Abstract;

namespace TechZone.Entities.Concrete;

public class BagItem : PrimaryEntity
{
    public int ProductId { get; set; }
    public DateTime CreateDate { get; set; } = DateTime.Now;
    public Product Product { get; set; }
    public int Quantity { get; set; }
    public int BagId { get; set; }
    public Bag Bag { get; set; }
}

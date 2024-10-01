using System;
using TechZone.Entities.Abstract;

namespace TechZone.Entities.Concrete;

public class Product : PrimaryEntity
{
    public string Title { get; set; }
    public decimal BasePrice { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    public int Stock { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
}

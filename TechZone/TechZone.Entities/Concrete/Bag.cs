using System;
using TechZone.Entities.Abstract;

namespace TechZone.Entities.Concrete;

public class Bag : PrimaryEntity
{
    public int UserId { get; set; }
    public Buyer Buyer { get; set; }
    public ICollection<BagItem> BagItems { get; set; } = new List<BagItem>();
}

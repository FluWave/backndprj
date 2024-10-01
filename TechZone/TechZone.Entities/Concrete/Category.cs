using System;
using TechZone.Entities.Abstract;

namespace TechZone.Entities.Concrete;

public class Category : PrimaryEntity
{
    public string Name { get; set; }
}

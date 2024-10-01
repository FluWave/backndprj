using System;

namespace TechZone.Entities.Abstract;

public abstract class PrimaryEntity
{
    public int Id { get; set; }
    public DateTime CreateDate { get; set; } = DateTime.Now;
    public DateTime UpdatedDate { get; set; } = DateTime.Now;
    public string Name { get; set; }
    public bool IsActive { get; set; }
    public string Url { get; set; }
}

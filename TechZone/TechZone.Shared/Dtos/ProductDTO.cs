using System;

namespace TechZone.Shared.Dtos;

public class ProductDTO
{
    public int Id { get; set; }
    public string Title { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    public int CategoryId { get; set; }
}

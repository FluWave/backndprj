using System;

namespace TechZone.Shared.Dtos;

public class BagDTO
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public List<BagItemDTO> BagItems { get; set; }
}

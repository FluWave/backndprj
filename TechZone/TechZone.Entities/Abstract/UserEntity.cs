using System;

namespace TechZone.Entities.Abstract;

public abstract class UserEntity : PrimaryEntity
{
    public string Name { get; set; }
    public string Email { get; set; }
}

using System;
using TechZone.Entities.Abstract;

namespace TechZone.Entities.Concrete;

public class User : UserEntity
{
    public int UserId { get; set; }
    public int Id { get; set; }
    public string UserName { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public ICollection<Bag> Bags { get; set; } = new List<Bag>();
}

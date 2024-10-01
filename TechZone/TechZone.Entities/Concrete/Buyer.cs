using System;
using TechZone.Entities.Abstract;
using TechZone.Shared.Types;

namespace TechZone.Entities.Concrete;

public class Buyer : UserEntity
{
    public int Id { get; set; }
    public string UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Password { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public string City { get; set; }
    public PaymentType PaymentType { get; set; }
    public List<BuyerItem> BuyerItems { get; set; }
}

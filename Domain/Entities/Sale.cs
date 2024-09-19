using Domain.Entities.Auth;
using Domain.Entities.Base;

namespace Domain.Entities;

public class Sale : BaseEntity<Guid>
{
    public DateTime SaleDate { get; set; }

    public List<SaleItem>? Items { get; set; }

    public decimal TotalAmount =>
        Items?.Sum(i => i.Price * i.Quantity) ?? 0;


    public string? CustomerId { get; set; }
    public ApplicationUser? Customer { get; set; }
}

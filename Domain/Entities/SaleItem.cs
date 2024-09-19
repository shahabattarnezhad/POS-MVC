using Domain.Entities.Base;

namespace Domain.Entities;

public class SaleItem : BaseEntity<Guid>
{
    public Guid ProductId { get; set; }

    public decimal Price { get; set; }

    public int Quantity { get; set; }
}

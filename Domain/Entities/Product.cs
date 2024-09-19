using Domain.Entities.Base;

namespace Domain.Entities;

public class Product : BaseEntity<Guid>
{
    public string? Name { get; set; }

    public decimal Price { get; set; }

    public int Stock { get; set; }

    public string? ImageUrl { get; set; }


    public Guid BrandId { get; set; }
    public Brand? Brand { get; set; }

    public Guid CategoryId { get; set; }
    public Category? Category { get; set; }
}

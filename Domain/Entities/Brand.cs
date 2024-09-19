using Domain.Entities.Base;

namespace Domain.Entities;

public class Brand : BaseEntity<Guid>
{
    public string? Name { get; set; }

    public string? LogoImageUrl { get; set; }

    public string? Description { get; set; }


    public ICollection<Product>? Products { get; set; }
}

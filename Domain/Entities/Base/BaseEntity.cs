namespace Domain.Entities.Base;

public class BaseEntity<T> where T : struct
{
    public T Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }
}

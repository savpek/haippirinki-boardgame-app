namespace Data;

public abstract record EntityBase
{
    public Guid Id { get; protected set; }
    public DateTime TimeStamp { get; init; } = DateTime.UtcNow;
}
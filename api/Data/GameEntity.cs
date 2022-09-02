namespace Data;

public record GameEntity : EntityBase
{
    public string Name { get; init; } = "";
    public decimal Weight { get; init; }

}

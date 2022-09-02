using Microsoft.EntityFrameworkCore;
namespace Data;

public class DataContext : DbContext
{
    public DbSet<GameEntity> Games { get; }
    public DbSet<ResultEntity> Results { get; }
}

public record ResultEntity: EntityBase
{
    public Guid ResultGroup { get; set; }
}

using Microsoft.EntityFrameworkCore;
namespace Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options): base(options)
    {
    }

    public DbSet<GameEntity> Games { get; protected set; }
    public DbSet<ResultEntity> Results { get; protected set; }
}

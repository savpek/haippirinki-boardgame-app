using Data;

namespace Utils;

public class DevelopmentData
{
    private readonly IServiceScopeFactory _scopeFactory;

    public DevelopmentData(IServiceScopeFactory scopeFactory)
    {
        _scopeFactory = scopeFactory;
    }

    public void AddDevelopmentData()
    {
        using var scope = _scopeFactory.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<DataContext>();
        
        context.Add(new GameEntity()
        {
            Name = "Brass: Birmingham",
            Weight = 3.91M,
        });

        context.Add(new GameEntity()
        {
            Name = "Terraforming Mars",
            Weight = 3.25M,
        });

        context.Add(new GameEntity()
        {
            Name = "Scythe",
            Weight = 3.43M,
        });
        
        context.SaveChanges();
    }
}
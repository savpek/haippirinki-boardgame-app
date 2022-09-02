using Data;

namespace Utils;

public class DevelopmentData
{
    private readonly DataContext _context;

    public DevelopmentData(DataContext context)
    {
        _context = context;
    }

    public void AddDevelopmentData()
    {
    }
}
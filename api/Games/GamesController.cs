using Data;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[ApiController]
public class GamesController : ControllerBase
{
    private readonly ILogger<GamesController> _logger;
    private readonly DataContext _context;

    public GamesController(ILogger<GamesController> logger, DataContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet("game")]
    public IEnumerable<GameEntity> Get()
    { 
        return _context.Games;
    }
}

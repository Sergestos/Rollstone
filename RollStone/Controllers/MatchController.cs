using Microsoft.AspNetCore.Mvc;
using RollStone.SessionState;

namespace RollStone.Host.Controllers;

[ApiController]
[Route("[controller]")]
public class MatchController : ControllerBase
{    
    private readonly ILogger<MatchController> _logger;

    public MatchController(ILogger<MatchController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [Route("state")]
    public IActionResult Get()
    {
        return Ok(MatchState.GetMatch());
    }

    [HttpPut]
    [Route("round/begin")]
    public IActionResult StartRound()
    {
        MatchState.Match.SetupNextRound();

        return Ok();
    }

    [HttpPut]
    [Route("play")]
    public IActionResult Put(int playerId, int cardId)
    {
        MatchState.Match.CurrentRound.PlayOut(playerId, cardId);

        return Ok(MatchState.Match.CurrentRound);
    }
}

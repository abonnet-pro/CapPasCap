using CapPasCap.Infra.Ports.Primary;
using CapPasCap.UsesCase.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace CapPasCap.WebService.Controllers;

[ApiController]
[Route("challenge")]
public class ChallengeController : ControllerBase
{
    private ChallengeAdapter _ChallengeAdapter;

    public ChallengeController(ChallengeAdapter challengeAdapter)
    {
        _ChallengeAdapter = challengeAdapter;
    }

    [HttpPost]
    [Route("create")]
    [Produces(MediaTypeNames.Application.Json)]
    [ProducesResponseType(statusCode: StatusCodes.Status200OK, Type = typeof(int))]
    [ProducesResponseType(statusCode: StatusCodes.Status400BadRequest, Type = typeof(string))]
    [ProducesResponseType(statusCode: StatusCodes.Status500InternalServerError)]
    public void createChallenge(string text, string login)
    {
        _ChallengeAdapter.createChallenge(text, login);
    }

    [HttpGet]
    [Route("all")]
    [Produces(MediaTypeNames.Application.Json)]
    [ProducesResponseType(statusCode: StatusCodes.Status200OK, Type = typeof(List<Challenge>))]
    [ProducesResponseType(statusCode: StatusCodes.Status400BadRequest, Type = typeof(string))]
    [ProducesResponseType(statusCode: StatusCodes.Status500InternalServerError)]
    public List<Challenge> GetChallenges()
    {
        return _ChallengeAdapter.getAll();
    }

    [HttpPut]
    [Route("like")]
    [Produces(MediaTypeNames.Application.Json)]
    [ProducesResponseType(statusCode: StatusCodes.Status200OK, Type = typeof(int))]
    [ProducesResponseType(statusCode: StatusCodes.Status400BadRequest, Type = typeof(string))]
    [ProducesResponseType(statusCode: StatusCodes.Status500InternalServerError)]
    public void likeChallenge(int id)
    {
        _ChallengeAdapter.likeChallenge(id);
    }
}


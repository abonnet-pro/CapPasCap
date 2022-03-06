using CapPasCap.Infra.Ports.Primary;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace CapPasCap.WebService.Controllers;

[ApiController]
[Route("user")]
public class UserController : ControllerBase
{
    private UserAdapter _UserAdapter;

    public UserController(UserAdapter userAdapter)
    {
        _UserAdapter = userAdapter;
    }

    [HttpPost]
    [Route("create")]
    [Produces(MediaTypeNames.Application.Json)]
    [ProducesResponseType(statusCode: StatusCodes.Status200OK, Type = typeof(int))]
    [ProducesResponseType(statusCode: StatusCodes.Status400BadRequest, Type = typeof(string))]
    [ProducesResponseType(statusCode: StatusCodes.Status500InternalServerError)]
    public string createUser(string login, string password)
    {
        return _UserAdapter.createUser(login, password);
    }

    [HttpPost]
    [Route("login")]
    [Produces(MediaTypeNames.Application.Json)]
    [ProducesResponseType(statusCode: StatusCodes.Status200OK, Type = typeof(bool))]
    [ProducesResponseType(statusCode: StatusCodes.Status400BadRequest, Type = typeof(string))]
    [ProducesResponseType(statusCode: StatusCodes.Status500InternalServerError)]
    public bool authUser(string login, string password)
    {
        return _UserAdapter.authUser(login, password);
    }
}


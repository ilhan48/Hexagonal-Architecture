using Core.Application.Commands.Users.Create;
using Core.Application.Ports.Driving;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Adapter.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly IUserService _userService;
    private readonly IMediator _mediator;

    public UsersController(IUserService userService, IMediator mediator)
    {
        _userService = userService;
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateUserCommandRequest request)
    {
        CreateUserCommandResponse response = await _mediator.Send(request);
        return CreatedAtAction("", response);
    }
}
﻿using MediatR;

namespace Core.Application.Commands.Users.Create;

public class CreateUserCommandRequest : IRequest<CreateUserCommandResponse>
{
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public string UserName { get; set; }
	public string Email { get; set; }
}





using Core.Application.Ports.Driving;
using Core.Domain.Dtos.User;
using FluentValidation;
using MediatR;

namespace Core.Application.Commands.Users.Create;

public class CreateUserCommandHandler : IRequestHandler<CreateUserCommandRequest, CreateUserCommandResponse>
{
    private readonly IUserService _userService;
    private readonly IValidator<CreateUserCommandRequest> _validator;

    public CreateUserCommandHandler(IUserService userService, IValidator<CreateUserCommandRequest> validator)
    {
        _userService = userService;
        _validator = validator;
    }

    public async Task<CreateUserCommandResponse> Handle(CreateUserCommandRequest request, CancellationToken cancellationToken)
    {
        var validationResult = _validator.Validate(request);
        if (!validationResult.IsValid)
        {
            var errors = validationResult.Errors.Select(err => err.ErrorMessage).ToList();
            return new CreateUserCommandResponse
            {
                Succeeded = false,
                Message = errors
            };
        }

        CreateUserResponse response = await _userService.CreateAsync(new()
        {
            FirstName = request.FirstName,
            LastName = request.LastName,
            UserName = request.UserName,
            Email = request.Email
        });

        return new()
        {
            Message = {$"{request.FirstName} registred.", $"User Name : {request.UserName}"},
            Succeeded = response.Succeeded
        };
    }
}
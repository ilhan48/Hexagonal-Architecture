using Core.Application.Ports.Driven;
using Core.Application.Ports.Driving;
using Core.Domain.Dtos.User;

namespace Core.Application.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<CreateUserResponse> CreateAsync(CreateUser createUser)
    {
        if (createUser.Email != createUser.EmailConfirm)
        {
            return new CreateUserResponse()
            {
                Succeeded = false,
                Message = $"You don't pass email confirmation {createUser.Email} not equal {createUser.EmailConfirm}"
            };
        }
        
        await _userRepository.AddAsync(new()
        {
            FirstName = createUser.FirstName,
            LastName = createUser.LastName,
            EmailAddress = createUser.Email,
            UserName = createUser.UserName,
        });
        CreateUserResponse response = new() { Succeeded = true };

        return response;
    }
}
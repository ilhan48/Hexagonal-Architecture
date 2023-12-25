using Core.Domain.Dtos.User;

namespace Core.Application.Ports.Driving;

public interface IUserService
{
    public Task<CreateUserResponse> CreateAsync(CreateUser model);
}
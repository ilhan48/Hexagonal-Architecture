namespace Core.Application.Commands.Users.Create;

public class CreateUserCommandResponse
{
    public bool Succeeded { get; set; }
    public List<string>? Message { get; set; }
}
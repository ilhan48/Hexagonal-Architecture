namespace Core.Domain.Dtos.User;

public class CreateUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string EmailConfirm { get; set; }
}
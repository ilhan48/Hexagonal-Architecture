using Core.Domain.Entities.Common;

namespace Core.Domain.Entities;
public class User : BaseEntity<Guid>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string EmailAddress { get; set; }
    public string UserName { get; set; }
    public bool Status { get; set; }
    
}
using Core.Application.Ports.Driven;
using Core.Application.Ports.Driven.Core.EntityFramework;

namespace Adapter.PostgreSQL.User;

public class UserRepository : EfRepositoryBase<Core.Domain.Entities.User, Guid, PetManagementDbContext>, IUserRepository
{
    public UserRepository(PetManagementDbContext context) : base(context)
    {
    }
}
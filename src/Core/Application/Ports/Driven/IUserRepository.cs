using Core.Application.Ports.Driven.Core.Abstracts;
using Core.Domain.Entities;

namespace Core.Application.Ports.Driven;

public interface IUserRepository : IAsyncRepository<User, Guid>
{
    
}
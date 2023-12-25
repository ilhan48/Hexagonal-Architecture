using Core.Domain.Entities.Common;

namespace Core.Application.Ports.Driven.Core.Abstracts;

public interface IAsyncRepository<TEntity, TEntityId> : IQuery<TEntity>
    where TEntity : BaseEntity<TEntityId>
{
    Task<TEntity> AddAsync(TEntity entity);
    Task<int> SaveAsync();
}
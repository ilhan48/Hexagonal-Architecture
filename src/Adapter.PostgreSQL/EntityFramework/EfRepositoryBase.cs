using Core.Application.Ports.Driven.Core.Abstracts;
using Core.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace Core.Application.Ports.Driven.Core.EntityFramework;

public class EfRepositoryBase<TEntity, TEntityId, TContext> : IAsyncRepository<TEntity, TEntityId>
    where TEntity : BaseEntity<TEntityId>
    where TContext : DbContext
{
    protected readonly TContext Context;

    public EfRepositoryBase(TContext context)
    {
        Context = context;
    }
    public async Task<int> SaveAsync()
        => await Context.SaveChangesAsync();
    public IQueryable<TEntity> Query()
    {
        return Context.Set<TEntity>();
    }

    public async Task<TEntity> AddAsync(TEntity entity)
    {
        entity.CreatedDate = DateTime.UtcNow;
        await Context.AddAsync(entity);
        await Context.SaveChangesAsync();
        return entity;

    }

}
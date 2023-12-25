using Microsoft.EntityFrameworkCore;

namespace Adapter.PostgreSQL;

public class PetManagementDbContext : DbContext
{
    public PetManagementDbContext(DbContextOptions<PetManagementDbContext> options) : base(options)
    {
        
    }
    public virtual DbSet<Core.Domain.Entities.User> Users { get; set; }
}

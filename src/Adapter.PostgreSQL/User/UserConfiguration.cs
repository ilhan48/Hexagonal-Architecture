using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Adapter.PostgreSQL.User;

public class UserConfiguration : IEntityTypeConfiguration<Core.Domain.Entities.User>
{
    public void Configure(EntityTypeBuilder<Core.Domain.Entities.User> builder)
    {
        builder.HasKey(u => u.Id);
    }
}
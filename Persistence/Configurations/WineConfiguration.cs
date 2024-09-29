using Domain.Entities.Wines;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations;

internal sealed class WineConfiguration : IEntityTypeConfiguration<Wine>
{
    public void Configure(EntityTypeBuilder<Wine> builder)
    {
        builder.Property(static m => m.Id).HasField("_id").ValueGeneratedNever();
        builder.Property(static m => m.Title).HasField("_title");
        builder.Property(static m => m.Description).HasField("_description");

        builder.HasIndex(static m => m.Title).IsUnique();
    }
}
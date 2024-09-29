using Domain.Entities.Colors;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations;

internal sealed class ColorConfiguration : IEntityTypeConfiguration<Color>
{
    public void Configure(EntityTypeBuilder<Color> builder)
    {
        builder.Property(static m => m.Id).HasField("_id").ValueGeneratedNever();
        builder.Property(static m => m.Title).HasField("_title");
        
        builder.HasIndex(static m => m.Title).IsUnique();
    }
}
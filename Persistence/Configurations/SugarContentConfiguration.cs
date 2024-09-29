using Domain.Entities.SugarContents;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations;

internal sealed class SugarContentConfiguration : IEntityTypeConfiguration<SugarContent>
{
    public void Configure(EntityTypeBuilder<SugarContent> builder)
    {
        builder.Property(static m => m.Id).HasField("_id").ValueGeneratedNever();
        builder.Property(static m => m.Title).HasField("_title");
        
        builder.HasIndex(static m => m.Title).IsUnique();
    }
}
using Domain.Entities.Colors;
using Domain.Entities.SugarContents;
using Domain.Entities.Wines;
using Microsoft.EntityFrameworkCore;
using Persistence.Contracts;

namespace Persistence;

internal sealed class DbContextAdapter(DbContext context) : 
    IDbContext,
    IMigrationContext,
    ITransactionContext
{
    public IDbSet<Wine> Wines { get; } =
        new DbSetAdapter<Wine>(context);
    
    public IDbSet<SugarContent> SugarContents { get; } =
        new DbSetAdapter<SugarContent>(context);
    
    public IDbSet<Color> Colors { get; } =
        new DbSetAdapter<Color>(context);

    public Task SaveChangesAsync(CancellationToken cancellationToken)
    {
        return context.SaveChangesAsync(cancellationToken: cancellationToken);
    }

    public Task MigrateAsync(CancellationToken cancellationToken = default)
    {
        return context.Database.MigrateAsync(cancellationToken);
    }

    public Task BeginTransactionAsync(CancellationToken cancellationToken)
    {
        return context.Database.BeginTransactionAsync(cancellationToken);
    }

    public Task CommitTransactionAsync(CancellationToken cancellationToken)
    {
        return context.Database.CommitTransactionAsync(cancellationToken);
    }

    public Task RollbackTransactionAsync(CancellationToken cancellationToken)
    {
        return context.Database.RollbackTransactionAsync(cancellationToken);
    }
}
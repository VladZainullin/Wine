using Domain.Entities.Colors;
using Domain.Entities.SugarContents;
using Domain.Entities.Wines;

namespace Persistence.Contracts;

public interface IDbContext
{
    IDbSet<Wine> Wines { get; }
    
    IDbSet<Color> Colors { get; }
    
    IDbSet<SugarContent> SugarContents { get; }
    
    Task SaveChangesAsync(CancellationToken cancellationToken);
}
using Domain.Entities.Colors;

namespace Domain.Entities.Wines.Parameters;

public sealed class SetWineColorParameters
{
    public required Color Color { get; init; }
}
using Domain.Entities.Colors;
using Domain.Entities.SugarContents;

namespace Domain.Entities.Wines.Parameters;

public readonly struct CreateWineParameters
{
    public required string Title { get; init; }

    public required string Description { get; init; }

    public required SugarContent SugarContent { get; init; }

    public required Color Color { get; init; }
}
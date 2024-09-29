using Domain.Entities.SugarContents;

namespace Domain.Entities.Wines.Parameters;

public readonly struct SetWineSugarContentParameters
{
    public required SugarContent SugarContent { get; init; }
}
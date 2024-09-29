namespace Domain.Entities.Wines.Parameters;

public readonly struct SetWineTitleParameters
{
    public required string Title { get; init; }
}
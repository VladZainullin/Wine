namespace Domain.Entities.SugarContents.Parameters;

public readonly struct CreateSugarContentParameters
{
    public required string Title { get; init; }
}
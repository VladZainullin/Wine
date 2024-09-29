using Domain.Entities.Colors.Parameters;

namespace Domain.Entities.Colors;

public sealed class Color
{
    private Guid _id = Guid.NewGuid();
    private string _title = default!;
    
    public Color(CreateColorParameters parameters)
    {
        SetTitle(new SetColorTitleParameters
        {
            Title = parameters.Title
        });
    }

    public string Title => _title;
    
    public void SetTitle(SetColorTitleParameters parameters)
    {
        _title = parameters.Title.Trim();
    }
}
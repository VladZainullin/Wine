using Domain.Entities.Colors.Parameters;

namespace Domain.Entities.Colors;

public sealed class Color
{
    private Guid _id = Guid.NewGuid();
    private string _title = default!;

    private Color()
    {
    }
    
    public Color(CreateColorParameters parameters) : this()
    {
        SetTitle(new SetColorTitleParameters
        {
            Title = parameters.Title
        });
    }

    public Guid Id => _id;
    
    public string Title => _title;
    
    public void SetTitle(SetColorTitleParameters parameters)
    {
        _title = parameters.Title.Trim();
    }
}
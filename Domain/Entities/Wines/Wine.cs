using Domain.Entities.Colors;
using Domain.Entities.SugarContents;
using Domain.Entities.Wines.Parameters;

namespace Domain.Entities.Wines;

public sealed class Wine
{
    private Guid _id = Guid.NewGuid();
    
    private string _title = default!;
    private string _description = default!;

    private SugarContent _sugarContent = default!;
    private Color _color = default!;

    private Wine()
    {
    }
    
    public Wine(CreateWineParameters parameters) : this()
    {
        SetTitle(new SetWineTitleParameters
        {
            Title = parameters.Title
        });
        
        SetDescription(new SetWineDescriptionParameters
        {
            Description = parameters.Description
        });
        
        SetSugarContent(new SetWineSugarContentParameters
        {
            SugarContent = parameters.SugarContent
        });
        
        SetColor(new SetWineColorParameters
        {
            Color = parameters.Color
        });
    }

    public Guid Id => _id;

    public string Title => _title;

    public void SetTitle(SetWineTitleParameters parameters)
    {
        _title = parameters.Title.Trim();
    }

    public string Description => _description;

    public void SetDescription(SetWineDescriptionParameters parameters)
    {
        _description = parameters.Description.Trim();
    }
    
    public Color Color => _color;

    public void SetColor(SetWineColorParameters parameters)
    {
        _color = parameters.Color;
    }

    public SugarContent SugarContent => _sugarContent;

    public void SetSugarContent(SetWineSugarContentParameters parameters)
    {
        _sugarContent = parameters.SugarContent;
    }
}
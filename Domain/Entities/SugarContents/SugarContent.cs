using Domain.Entities.SugarContents.Parameters;

namespace Domain.Entities.SugarContents;

public sealed class SugarContent
{
    private Guid _id = Guid.NewGuid();
    private string _title = default!;

    private SugarContent()
    {
    }
    
    public SugarContent(CreateSugarContentParameters parameters) : this()
    {
        SetTitle(new SetSugarContentTitleParameters
        {
            Title = parameters.Title
        });
    }

    public Guid Id => _id;

    public string Title => _title;

    public void SetTitle(SetSugarContentTitleParameters parameters)
    {
        _title = parameters.Title.Trim();
    }
}
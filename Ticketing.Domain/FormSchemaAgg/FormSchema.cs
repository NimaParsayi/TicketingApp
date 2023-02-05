using Ticketing.Domain.FormSchemaAgg.Services;
using Ticketing.Domain.FormSchemaFieldAgg;

namespace Ticketing.Domain.FormSchemaAgg;

public class FormSchema
{
    #region Properties

    public int Id { get; private set; }
    public string Title { get; private set; }
    public string Description { get; private set; }
    public bool IsActive { get; private set; }
    public DateTime CreationDate { get; private set; }
    public IEnumerable<FormSchemaField> Fields { get; private set; }

    #endregion

    #region Constructors

    protected FormSchema() { }

    public FormSchema(string title, string description, IFormSchemaValidator validator)
    {
        validator.CheckTitleIsNotEmpty(title);
        validator.CheckDescriptionIsNotEmpty(description);
        Title = title;
        Description = description;
        IsActive = true;
        Fields = new List<FormSchemaField>();
    }

    #endregion

    #region Methods
    
    public void Update(string title, string description, IFormSchemaValidator validator)
    {
        validator.CheckTitleIsNotEmpty(title);
        validator.CheckDescriptionIsNotEmpty(description);
        Title = title;
        Description = description;
    }

    public void Active() => IsActive = true;

    public void DeActive() => IsActive = false;

    #endregion
}
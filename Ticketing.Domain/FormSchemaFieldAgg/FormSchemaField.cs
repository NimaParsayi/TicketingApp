using Ticketing.Domain.FormSchemaAgg;

namespace Ticketing.Domain.FormSchemaFieldAgg;

public class FormSchemaField
{
    #region Properties

    public int Id { get; private set; }
    public string Title { get; private set; }
    public string Description { get; private set; }
    public int FormSchemaId { get; private set; }
    public bool IsActive { get; private set; }
    public FormSchema FormSchema { get; private set; }

    #endregion

    #region Constructors

    protected FormSchemaField() { }

    public FormSchemaField(string title, string description, int formSchemaId)
    {
        Title = title;
        Description = description;
        FormSchemaId = formSchemaId;
        IsActive = true;
    }

    #endregion

    #region Methods

    public void Update(string title, string description)
    {
        Title = title;
        Description = description;
    }

    public void DeActive() => IsActive = false;

    #endregion
}
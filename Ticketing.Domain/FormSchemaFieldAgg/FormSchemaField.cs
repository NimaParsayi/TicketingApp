using Ticketing.Domain.FormSchemaAgg;
using Ticketing.Domain.FormSchemaFieldAgg.Enums;
using Ticketing.Domain.FormSchemaFieldAgg.Services;

namespace Ticketing.Domain.FormSchemaFieldAgg;

public class FormSchemaField
{
    #region Properties

    public int Id { get; private set; }
    public string Title { get; private set; }
    public string Description { get; private set; }
    public FormSchemaFieldType Type { get; private set; }
    public int FormSchemaId { get; private set; }
    public bool IsActive { get; private set; }
    public DateTime CreationDate { get; private set; }
    public FormSchema FormSchema { get; private set; }

    #endregion

    #region Constructors

    protected FormSchemaField() { }

    public FormSchemaField(string title, string description, int formSchemaId, FormSchemaFieldType type, IFormSchemaFieldValidator validator)
    {
        validator.CheckTitleIsNotEmpty(title);
        validator.CheckDescriptionIsNotEmpty(description);
        Title = title;
        Description = description;
        Type = type;
        FormSchemaId = formSchemaId;
        IsActive = true;
        CreationDate = DateTime.Now;
    }

    #endregion

    #region Methods

    public void Update(string title, string description, int type, IFormSchemaFieldValidator validator)
    {
        validator.CheckTitleIsNotEmpty(title);
        validator.CheckDescriptionIsNotEmpty(description);
        Title = title;
        Description = description;
        Type = (FormSchemaFieldType)type;
    }

    public void Active() => IsActive = true;

    public void DeActive() => IsActive = false;

    #endregion
}
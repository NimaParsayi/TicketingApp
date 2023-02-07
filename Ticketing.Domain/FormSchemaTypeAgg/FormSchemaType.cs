using Ticketing.Domain.FormSchemaAgg;

namespace Ticketing.Domain.FormSchemaTypeAgg;

public class FormSchemaType
{
    #region Properties
    
    public int Id { get; private set; }
    public string Title { get; private set; }
    public bool IsActive { get; private set; }
    public DateTime CreationDate { get; private set; }
    public FormSchema Schema { get; private set; }

    #endregion

    #region Constructors

    protected FormSchemaType(){}

    public FormSchemaType(string title)
    {
        Title = title;
        CreationDate = DateTime.Now;
        IsActive = true;
    }

    #endregion

    #region Methods

    public void Update(string title) => Title = title;

    public void Active() => IsActive = true;

    public void DeActive() => IsActive = false;


    #endregion
}
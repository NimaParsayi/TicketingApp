namespace Ticketing.Application.Contracts.FormSchemaType.ViewModels;

public class FormSchemaTypeViewModel
{
    public int Id { get; set; }
    public string Title { get; set; }
    public bool IsActive { get; set; }
    public string CreationDate { get; set; }
}
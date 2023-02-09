namespace Ticketing.Application.Contracts.FormSchema.ViewModels;

public class FormSchemaViewModel
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string CreationDate { get; set; }
    public int TypeId { get; set; }
}
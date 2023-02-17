namespace Ticketing.Application.Contracts.FormSchemaField.ViewModels;

public class FormSchemaFieldViewModel
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Type { get; set; }
    public string CreationDate { get; set; }
    public int FormSchemaId { get; set; }
}
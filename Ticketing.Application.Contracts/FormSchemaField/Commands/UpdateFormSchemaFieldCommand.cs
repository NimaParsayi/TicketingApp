namespace Ticketing.Application.Contracts.FormSchemaField.Commands;

public class UpdateFormSchemaFieldCommand
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
}
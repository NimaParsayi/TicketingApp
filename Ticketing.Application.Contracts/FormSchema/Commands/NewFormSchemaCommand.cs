namespace Ticketing.Application.Contracts.FormSchema.Commands;

public class NewFormSchemaCommand
{
    public string Title { get; set; }
    public string Description { get; set; }
    public int TypeId { get; set; }
}
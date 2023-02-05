namespace Ticketing.Application.Contracts.FormSchema.Commands;

public class UpdateFormSchemaCommand
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
}
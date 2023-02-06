using Ticketing.Domain.FormSchemaFieldAgg;

namespace Ticketing.Infrastructure.EFCore.Services;

public class FormSchemaFieldRepository : IFormSchemaFieldRepository
{
    private readonly TicketingContext context;
    public FormSchemaFieldRepository(TicketingContext context)
    {
        this.context = context;
    }

    public IList<FormSchemaField> Get() => context.FormSchemasFields.ToList();

    public FormSchemaField GetBy(int id) => context.FormSchemasFields.Find(id);

    public void Add(FormSchemaField formSchemaField) => context.FormSchemasFields.Add(formSchemaField);

    public void Update(FormSchemaField formSchemaField)
    {
        throw new NotImplementedException();
    }

    public void Active(int id)
    {
        throw new NotImplementedException();
    }

    public void DeActive(int id)
    {
        throw new NotImplementedException();
    }

    public void Save() => context.SaveChangesAsync();
}
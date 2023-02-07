using Microsoft.EntityFrameworkCore;
using Ticketing.Domain.FormSchemaFieldAgg;

namespace Ticketing.Infrastructure.EFCore.Services;

public class FormSchemaFieldRepository : IFormSchemaFieldRepository
{
    private readonly TicketingContext context;
    public FormSchemaFieldRepository(TicketingContext context)
    {
        this.context = context;
    }

    public IList<FormSchemaField> Get() => context.FormSchemasFields.Include(x => x.FormSchema).ToList();

    public FormSchemaField GetBy(int id) => context.FormSchemasFields.Include(x => x.FormSchema).FirstOrDefault(x => x.Id == id);

    public void Add(FormSchemaField formSchemaField) => context.FormSchemasFields.Add(formSchemaField);

    public void Save() => context.SaveChangesAsync();
}
using Ticketing.Domain.FormSchemaAgg;

namespace Ticketing.Infrastructure.EFCore.Services;

public class FormSchemaRepository : IFormSchemaRepository
{
    private readonly TicketingContext context;
    public FormSchemaRepository(TicketingContext context)
    {
        this.context = context;
    }

    public IList<FormSchema> Get() => context.FormSchemas.ToList();

    public FormSchema GetBy(int id) => context.FormSchemas.Find(id);

    public void Add(FormSchema formSchema) => context.Add(formSchema);

    public void Update(FormSchema formSchema)
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

    public void Save() => context.SaveChanges();
}
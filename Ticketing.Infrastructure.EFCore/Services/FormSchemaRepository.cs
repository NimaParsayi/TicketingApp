using Microsoft.EntityFrameworkCore;
using Ticketing.Domain.FormSchemaAgg;

namespace Ticketing.Infrastructure.EFCore.Services;

public class FormSchemaRepository : IFormSchemaRepository
{
    private readonly TicketingContext context;
    public FormSchemaRepository(TicketingContext context)
    {
        this.context = context;
    }

    public IList<FormSchema> Get() => context.FormSchemas.Include(x => x.Fields).ToList();

    public FormSchema GetBy(int id) => context.FormSchemas.Include(x => x.Fields).FirstOrDefault(x => x.Id == id);

    public void Add(FormSchema formSchema) => context.Add(formSchema);

    public void Save() => context.SaveChanges();
}
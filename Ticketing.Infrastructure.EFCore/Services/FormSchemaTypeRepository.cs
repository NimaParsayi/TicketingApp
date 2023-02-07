using Ticketing.Domain.FormSchemaTypeAgg;

namespace Ticketing.Infrastructure.EFCore.Services;

public class FormSchemaTypeRepository : IFormSchemaTypeRepository
{
    private readonly TicketingContext context;
    public FormSchemaTypeRepository(TicketingContext context)
    {
        this.context = context;
    }

    public List<FormSchemaType> Get() => context.FormSchemaTypes.ToList();

    public FormSchemaType GetBy(int id) => context.FormSchemaTypes.Find(id);

    public void Add(FormSchemaType formSchemaType) => context.Add(formSchemaType);

    public void Save() => context.SaveChanges();
}
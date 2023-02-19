using Ticketing.Domain.FormAgg;

namespace Ticketing.Infrastructure.EFCore.Services;

public class FormRepository : IFormRepository
{
    private readonly TicketingContext context;
    public FormRepository(TicketingContext context)
    {
        this.context = context;
    }

    public IList<Form> Get() => context.Forms.ToList();

    public Form GetBy(int id) => context.Forms.Find(id);

    public IList<Form> GetBy(string mobile) => context.Forms.Where(x => x.Mobile == mobile).ToList();

    public void Save() => context.SaveChanges();
}

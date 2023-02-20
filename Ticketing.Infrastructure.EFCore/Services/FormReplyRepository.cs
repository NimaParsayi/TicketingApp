using Microsoft.EntityFrameworkCore;
using Ticketing.Domain.FormReplyAgg;

namespace Ticketing.Infrastructure.EFCore.Services;

public class FormReplyRepository : IFormReplyRepository
{
    private readonly TicketingContext context;
    public FormReplyRepository(TicketingContext context)
    {
        this.context = context;
    }

    public IList<FormReply> Get() => context.FormsReplies.Include(x => x.Form).ToList();

    public FormReply GetBy(long id) => context.FormsReplies.Include(x => x.Form).FirstOrDefault(x => x.Id == id);

    public IList<FormReply> GetBy(string mobile) => context.FormsReplies.Include(x => x.Form).Where(x => x.Mobile == mobile).ToList();

    public void Add(FormReply formReply) => context.FormsReplies.Add(formReply);

    public void Save() => context.SaveChanges();
}

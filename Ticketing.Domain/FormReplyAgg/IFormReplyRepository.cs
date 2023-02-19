namespace Ticketing.Domain.FormReplyAgg;

public interface IFormReplyRepository
{
    IList<FormReply> Get();
    FormReply GetBy(long id);
    IList<FormReply> GetBy(string mobile);
    void Add(FormReply formReply);
    void Save();
}

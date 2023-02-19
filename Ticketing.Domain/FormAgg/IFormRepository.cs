namespace Ticketing.Domain.FormAgg;

public interface IFormRepository
{
    IList<Form> Get();
    Form GetBy(int id);
    IList<Form> GetBy(string mobile);
    void Save();
}

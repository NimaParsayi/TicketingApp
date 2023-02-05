namespace Ticketing.Domain.FormSchemaAgg;

public interface IFormSchemaRepository
{
    IList<FormSchema> Get();
    FormSchema GetBy(int id);
    void Add(FormSchema formSchema);
    void Save();
}
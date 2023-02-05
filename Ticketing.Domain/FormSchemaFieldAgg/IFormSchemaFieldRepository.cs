using Ticketing.Domain.FormSchemaAgg;

namespace Ticketing.Domain.FormSchemaFieldAgg;

public interface IFormSchemaFieldRepository
{
    IList<FormSchemaField> Get();
    FormSchemaField GetBy(int id);
    void Add(FormSchema formSchema);
    void Update(FormSchema formSchema);
    void Active(int id);
    void DeActive(int id);
    void Save();
}
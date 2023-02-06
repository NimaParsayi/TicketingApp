using Ticketing.Domain.FormSchemaAgg;

namespace Ticketing.Domain.FormSchemaFieldAgg;

public interface IFormSchemaFieldRepository
{
    IList<FormSchemaField> Get();
    FormSchemaField GetBy(int id);
    void Add(FormSchemaField formSchemaField);
    void Update(FormSchemaField formSchemaField);
    void Active(int id);
    void DeActive(int id);
    void Save();
}
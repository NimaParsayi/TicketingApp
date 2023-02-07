namespace Ticketing.Domain.FormSchemaFieldAgg;

public interface IFormSchemaFieldRepository
{
    IList<FormSchemaField> Get();
    FormSchemaField GetBy(int id);
    void Add(FormSchemaField formSchemaField);
    void Save();
}
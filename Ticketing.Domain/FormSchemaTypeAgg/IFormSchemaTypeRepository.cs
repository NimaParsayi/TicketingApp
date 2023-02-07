namespace Ticketing.Domain.FormSchemaTypeAgg;

public interface IFormSchemaTypeRepository
{
    List<FormSchemaType> Get();
    FormSchemaType GetBy(int id);
    void Add(FormSchemaType formSchemaType);
    void Save();
}
namespace Ticketing.Domain.FormTypeAgg;

public interface IFormSchemaTypeRepository
{
    List<FormSchemaType> Get();
    FormSchemaType GetBy(int id);
    void Add(FormSchemaType formSchemaType);
    void Save();
}
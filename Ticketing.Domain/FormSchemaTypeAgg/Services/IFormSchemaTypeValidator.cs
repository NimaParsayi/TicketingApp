namespace Ticketing.Domain.FormSchemaTypeAgg.Services;

public interface IFormSchemaTypeValidator
{
    void CheckTitleIsNotEmpty(string title);
}
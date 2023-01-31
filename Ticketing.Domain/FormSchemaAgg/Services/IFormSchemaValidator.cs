namespace Ticketing.Domain.FormSchemaAgg.Services;

public interface IFormSchemaValidator
{
    void CheckTitleIsNotEmpty(string title);
    void CheckDescriptionIsNotEmpty(string description);
}
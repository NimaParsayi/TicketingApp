namespace Ticketing.Domain.FormSchemaAgg.Services;

public interface IFormSchemaFieldValidator
{
    void CheckTitleIsNotEmpty(string title);
    void CheckDescriptionIsNotEmpty(string description);
}
namespace Ticketing.Domain.FormSchemaFieldAgg.Services;

public interface IFormSchemaFieldValidator
{
    void CheckTitleIsNotEmpty(string title);
    void CheckDescriptionIsNotEmpty(string description);
}
using Ticketing.Domain.FormSchemaFieldAgg.Exceptions;

namespace Ticketing.Domain.FormSchemaAgg.Services;

public class FormSchemaFieldValidator : IFormSchemaFieldValidator
{
    public void CheckTitleIsNotEmpty(string title)
    {
        if (string.IsNullOrEmpty(title))
            throw new FormSchemaFieldTitleIsEmptyException();
    }

    public void CheckDescriptionIsNotEmpty(string description)
    {
        if (string.IsNullOrEmpty(description))
            throw new FormSchemaFieldDescriptionIsEmptyException();
    }
}

using Ticketing.Domain.FormSchemaAgg.Exceptions;

namespace Ticketing.Domain.FormSchemaAgg.Services;

public class FormSchemaValidator : IFormSchemaValidator
{
    public void CheckTitleIsNotEmpty(string title)
    {
        if (string.IsNullOrEmpty(title))
            throw new FormSchemaTitleIsEmptyException();
    }

    public void CheckDescriptionIsNotEmpty(string description)
    {
        if (string.IsNullOrEmpty(description))
            throw new FormSchemaDescriptionIsEmptyException();
    }
}

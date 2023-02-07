using Ticketing.Domain.FormSchemaAgg.Exceptions;
using Ticketing.Domain.FormSchemaFieldAgg.Exceptions;
using Ticketing.Domain.FormSchemaTypeAgg.Services;

namespace Ticketing.Domain.FormSchemaAgg.Services;

public class FormSchemaTypeValidator : IFormSchemaTypeValidator
{
    public void CheckTitleIsNotEmpty(string title)
    {
        if (string.IsNullOrEmpty(title))
            throw new FormSchemaFieldTitleIsEmptyException();
    }
}

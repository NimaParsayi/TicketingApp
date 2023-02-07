namespace Ticketing.Domain.FormSchemaTypeAgg.Exceptions;

public class FormSchemaTypeTitleIsEmptyException : Exception
{
    public FormSchemaTypeTitleIsEmptyException() : base("You should enter a Title for Form Schema Type, Because it's can't be empty.") { }
}
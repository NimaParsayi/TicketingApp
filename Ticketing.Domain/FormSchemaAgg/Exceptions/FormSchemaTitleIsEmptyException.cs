namespace Ticketing.Domain.FormSchemaAgg.Exceptions;

public class FormSchemaTitleIsEmptyException : Exception
{
    public FormSchemaTitleIsEmptyException() : base("You should enter a Title for Form Schema, Because it's can't be empty.") { }
}
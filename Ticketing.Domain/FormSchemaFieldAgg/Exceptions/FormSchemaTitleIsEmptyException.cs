namespace Ticketing.Domain.FormSchemaFieldAgg.Exceptions;

public class FormSchemaFieldTitleIsEmptyException : Exception
{
    public FormSchemaFieldTitleIsEmptyException() : base("You should enter a Title for Form Schema Field, Because it's can't be empty.") { }
}
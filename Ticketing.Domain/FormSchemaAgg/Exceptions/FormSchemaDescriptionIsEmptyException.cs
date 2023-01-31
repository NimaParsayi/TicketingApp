namespace Ticketing.Domain.FormSchemaAgg.Exceptions;

public class FormSchemaDescriptionIsEmptyException : Exception
{
    public FormSchemaDescriptionIsEmptyException() : base("You should enter a Description for Form Schema, Because it's can't be empty.") { }
}
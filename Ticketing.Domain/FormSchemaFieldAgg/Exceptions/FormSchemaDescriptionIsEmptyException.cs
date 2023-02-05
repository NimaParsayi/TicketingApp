namespace Ticketing.Domain.FormSchemaFieldAgg.Exceptions;

public class FormSchemaFieldDescriptionIsEmptyException : Exception
{
    public FormSchemaFieldDescriptionIsEmptyException() : base("You should enter a Description for Form Schema Field, Because it's can't be empty.") { }
}
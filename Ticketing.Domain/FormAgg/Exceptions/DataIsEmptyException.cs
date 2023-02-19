namespace Ticketing.Domain.FormAgg.Exceptions;

public class DataIsEmptyException : Exception
{
    public DataIsEmptyException() : base("Data field should have a value.") { }
}

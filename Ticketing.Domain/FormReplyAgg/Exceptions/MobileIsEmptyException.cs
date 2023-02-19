namespace Ticketing.Domain.FormReplyAgg.Exceptions;

public class MobileIsEmptyException : Exception
{
    public MobileIsEmptyException() : base("Mobile field should have a value.") { }
}

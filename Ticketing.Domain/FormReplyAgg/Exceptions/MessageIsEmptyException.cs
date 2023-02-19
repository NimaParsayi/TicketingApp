namespace Ticketing.Domain.FormReplyAgg.Exceptions;

public class MessageIsEmptyException : Exception
{
    public MessageIsEmptyException() : base("Message field should have a value.") { }
}

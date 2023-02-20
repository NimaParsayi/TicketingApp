namespace Ticketing.Application.Contracts.FormReply.Commands;

public class NewReplyCommand
{
    public string Message { get; set; }
    public string Mobile { get; set; }
    public int FormId { get; set; }
    public long ReplyToMessageId { get; set; }
}
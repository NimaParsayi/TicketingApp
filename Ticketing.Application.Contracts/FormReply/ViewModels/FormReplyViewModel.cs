namespace Ticketing.Application.Contracts.FormReply.ViewModels; 

public class FormReplyViewModel 
{
    public long Id { get; set; }
    public string Message { get; set; }
    public string Mobile { get; set; }
    public int FormId { get; set; }
    public long ReplyToMessageId { get; set; }
    public string CreationDate { get; set; }
}

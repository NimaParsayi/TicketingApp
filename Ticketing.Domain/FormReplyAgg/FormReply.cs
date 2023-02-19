using Ticketing.Domain.FormAgg;
using Ticketing.Domain.FormReplyAgg.Services;

namespace Ticketing.Domain.FormReplyAgg;

public class FormReply
{
    #region Properties

    public long Id { get; private set; }
    public string Message { get; private set; }
    public string Mobile { get; private set; }
    public int FormId { get; private set; }
    public long ReplyToMessageId { get; private set; }
    public DateTime CreationDate { get; private set; }
    public Form Form { get; private set; }
    public FormReply ReplyToMessage { get; private set; }

    #endregion

    #region Constructors

    protected FormReply() { }

    public FormReply(string message, string mobile, int formId, IFormReplyValidator validator, long replyToMessageId = 0)
    {
        validator.CheckMesssageIsNotEmpty(message);
        validator.CheckMobileCorrection(mobile);
        Message = message;
        Mobile = mobile;
        FormId = formId;
        if (replyToMessageId != 0)
            ReplyToMessageId = replyToMessageId;
    }

    #endregion

    #region Methods

    public void EditMessage(string message, IFormReplyValidator validator)
    {
        validator.CheckMesssageIsNotEmpty(message);
        Message = message;
    }

    public void EditMobile(string mobile, IFormReplyValidator validator)
    {
        validator.CheckMobileCorrection(mobile);
        Mobile = mobile;
    }

    #endregion
}

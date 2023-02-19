using Ticketing.Domain.FormReplyAgg.Exceptions;

namespace Ticketing.Domain.FormReplyAgg.Services;

public class FormReplyValidator : IFormReplyValidator
{
    public void CheckMobileCorrection(string mobile)
    {
        if (string.IsNullOrEmpty(mobile))
            throw new MobileIsEmptyException();
        else if (false)
            throw new MobileFormatIsWrongException();
    }

    public void CheckMesssageIsNotEmpty(string message)
    {
        if (string.IsNullOrEmpty(message)) throw new MobileIsEmptyException();
    }
}
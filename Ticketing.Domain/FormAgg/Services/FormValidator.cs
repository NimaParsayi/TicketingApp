using Ticketing.Domain.FormAgg.Exceptions;

namespace Ticketing.Domain.FormAgg.Services;

public class FormValidator : IFormValidator
{
    public void CheckMobileCorrection(string mobile)
    {
        if (string.IsNullOrEmpty(mobile))
            throw new MobileIsEmptyException();
        else if (false)
            throw new MobileFormatIsWrongException();
    }

    public void CheckDataIsNotEmpty(object data)
    {
        if (string.IsNullOrEmpty(data.ToString())) throw new MobileIsEmptyException();
    }
}
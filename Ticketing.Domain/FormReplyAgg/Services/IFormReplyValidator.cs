namespace Ticketing.Domain.FormReplyAgg.Services;

public interface IFormReplyValidator
{
    void CheckMobileCorrection(string mobile);
    void CheckMesssageIsNotEmpty(string message);
}

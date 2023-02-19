namespace Ticketing.Domain.FormAgg.Services;

public interface IFormValidator
{
    void CheckMobileCorrection(string mobile);
    void CheckDataIsNotEmpty(object data);
}

using Ticketing.Domain.FormAgg.Services;

namespace Ticketing.Domain.FormAgg;

public class Form
{
    #region Properties

    public int Id { get; private set; }
    public string Mobile { get; private set; }
    public string Data { get; private set; }
    public DateTime CreationDate { get; private set; }


    #endregion

    #region Constructors

    protected Form() { }

    public Form(string mobile, object data, IFormValidator validator)
    {
        validator.CheckMobileCorrection(mobile);
        validator.CheckDataIsNotEmpty(data);
        Mobile = mobile;
        Data = data;
        CreationDate = DateTime.Now;
    }

    #endregion

    #region Methods

    public void UpdateMobile(string mobile, IFormValidator validator)
    {
        validator.CheckMobileCorrection(mobile);
        Mobile = mobile;
    }

    #endregion
}
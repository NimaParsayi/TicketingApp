namespace Ticketing.Domain.FormAgg;

public class Form
{
    #region Properties

    public int Id { get; private set; }
    public string Mobile { get; private set; }
    public object Data { get; private set; }
    public DateTime CreationDate { get; private set; }


    #endregion

    #region Constructors

    protected Form() { }

    public Form(string mobile, object data)
    {
        Mobile = mobile;
        Data = data;
        CreationDate = DateTime.Now;
    }

    #endregion

    #region Methods

    

    #endregion
}
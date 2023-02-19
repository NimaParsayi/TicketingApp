namespace Ticketing.Domain.FormAgg.Exceptions;

public class MobileFormatIsWrongException : Exception
{
    public MobileFormatIsWrongException() : base("Mobile fomrat is not correct. You should use international fomrat (e.g: +989xxxxxxxxx).") { }
}

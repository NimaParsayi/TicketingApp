using Ticketing.Application.Contracts.Form.Commands;
using Ticketing.Application.Contracts.Form.ViewModels;

namespace Ticketing.Application.Contracts.Form;

public interface IFormApplication
{
    IList<FormViewModel> GetAll();
    FormViewModel GetBy(int id);
    IList<FormViewModel> GetBy(string mobile);
    void Add(AddFormCommand command);
}


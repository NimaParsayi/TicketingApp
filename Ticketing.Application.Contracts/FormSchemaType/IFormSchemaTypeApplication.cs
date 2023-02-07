using Ticketing.Application.Contracts.FormSchemaType.Commands;
using Ticketing.Application.Contracts.FormSchemaType.ViewModels;

namespace Ticketing.Application.Contracts.FormSchemaType;

public interface IFormSchemaTypeApplication
{
    IList<FormSchemaTypeViewModel> GetAll();
    FormSchemaTypeViewModel GetBy(int id);
    void Add(NewFormSchemaTypeCommand command);
    void Update(UpdateFormSchemaTypeCommand command);
    void Active(int formSchemaTypeId);
    void DeActive(int formSchemaTypeId);
}
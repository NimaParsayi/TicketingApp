using Ticketing.Application.Contracts.FormSchema.Commands;
using Ticketing.Application.Contracts.FormSchema.ViewModels;

namespace Ticketing.Application.Contracts.FormSchema;

public interface IFormSchemaApplication
{
    IList<FormSchemaViewModel> GetAll();
    FormSchemaViewModel GetBy(int id);
    FormSchemaStructureViewModel GetFormStructure(int typeId);
    void Add(NewFormSchemaCommand command);
    void Update(UpdateFormSchemaCommand command);
    void Active(int formSchemaId);
    void DeActive(int formSchemaId);
}
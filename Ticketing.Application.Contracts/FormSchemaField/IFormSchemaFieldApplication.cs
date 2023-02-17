using Ticketing.Application.Contracts.FormSchema.Commands;
using Ticketing.Application.Contracts.FormSchema.ViewModels;
using Ticketing.Application.Contracts.FormSchemaField.Commands;
using Ticketing.Application.Contracts.FormSchemaField.ViewModels;

namespace Ticketing.Application.Contracts.FormSchemaField;

public interface IFormSchemaFieldApplication
{
    IList<FormSchemaFieldViewModel> GetAll();
    FormSchemaFieldViewModel GetBy(int id);
    Array GetFieldTypes();
    void Add(NewFormSchemaFieldCommand command);
    void Update(UpdateFormSchemaFieldCommand command);
    void Active(int formSchemaFieldId);
    void DeActive(int formSchemaFieldId);
}
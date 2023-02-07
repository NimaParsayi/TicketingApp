using Ticketing.Application.Contracts.FormSchema.ViewModels;
using Ticketing.Application.Contracts.FormSchemaField;
using Ticketing.Application.Contracts.FormSchemaField.Commands;
using Ticketing.Application.Contracts.FormSchemaField.ViewModels;
using Ticketing.Domain.FormSchemaAgg;
using Ticketing.Domain.FormSchemaAgg.Services;
using Ticketing.Domain.FormSchemaFieldAgg;
using Ticketing.Domain.FormSchemaFieldAgg.Services;

namespace Ticketing.Application;

public class FormSchemaFieldApplication: IFormSchemaFieldApplication
{
    private readonly IFormSchemaFieldRepository formSchemaFieldRepository;
    private readonly IFormSchemaFieldValidator formSchemaFieldValidator;
    public FormSchemaFieldApplication(IFormSchemaFieldRepository formSchemaFieldRepository, IFormSchemaFieldValidator formSchemaFieldValidator)
    {
        this.formSchemaFieldRepository = formSchemaFieldRepository;
        this.formSchemaFieldValidator = formSchemaFieldValidator;
    }

    public IList<FormSchemaFieldViewModel> GetAll()
    {
        var list = new List<FormSchemaFieldViewModel>();
        foreach (var formSchemaField in formSchemaFieldRepository.Get())
        {
            list.Add(new FormSchemaFieldViewModel()
            {
                Id = formSchemaField.Id,
                Title = formSchemaField.Title,
                Description = formSchemaField.Description,
                CreationDate = formSchemaField.CreationDate.ToShortDateString(),
                FormSchemaId = formSchemaField.FormSchemaId
            });
        }

        return list;
    }

    public FormSchemaFieldViewModel GetBy(int id)
    {
        var formSchemaField = formSchemaFieldRepository.GetBy(id);
        return new FormSchemaFieldViewModel()
        {
            Id = formSchemaField.Id,
            Title = formSchemaField.Title,
            Description = formSchemaField.Description,
            CreationDate = formSchemaField.CreationDate.ToShortDateString(),
            FormSchemaId = formSchemaField.FormSchemaId
        };
    }

    public void Add(NewFormSchemaFieldCommand command)
    {
        formSchemaFieldRepository.Add(new FormSchemaField(command.Title, command.Description, command.FormSchemaId, formSchemaFieldValidator));
        formSchemaFieldRepository.Save();
    }

    public void Update(UpdateFormSchemaFieldCommand command)
    {
        formSchemaFieldRepository.GetBy(command.Id).Update(command.Title, command.Description, formSchemaFieldValidator);
        formSchemaFieldRepository.Save();
    }

    public void Active(int formSchemaFieldId)
    {
        formSchemaFieldRepository.GetBy(formSchemaFieldId).Active();
        formSchemaFieldRepository.Save();
    }

    public void DeActive(int formSchemaFieldId)
    {
        formSchemaFieldRepository.GetBy(formSchemaFieldId).DeActive();
        formSchemaFieldRepository.Save();
    }
}
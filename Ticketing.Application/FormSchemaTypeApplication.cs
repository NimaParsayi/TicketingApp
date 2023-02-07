using Ticketing.Application.Contracts.FormSchemaType;
using Ticketing.Application.Contracts.FormSchemaType.Commands;
using Ticketing.Application.Contracts.FormSchemaType.ViewModels;
using Ticketing.Domain.FormSchemaTypeAgg;
using Ticketing.Domain.FormSchemaTypeAgg.Services;

namespace Ticketing.Application;

public class FormSchemaTypeApplication: IFormSchemaTypeApplication
{
    private readonly IFormSchemaTypeValidator formSchemaTypeValidator;
    private readonly IFormSchemaTypeRepository formSchemaTypeRepository;
    public FormSchemaTypeApplication(IFormSchemaTypeValidator formSchemaTypeValidator, IFormSchemaTypeRepository formSchemaTypeRepository)
    {
        this.formSchemaTypeValidator = formSchemaTypeValidator;
        this.formSchemaTypeRepository = formSchemaTypeRepository;
    }

    public IList<FormSchemaTypeViewModel> GetAll()
    {
        var list = new List<FormSchemaTypeViewModel>();
        foreach (var formSchemaType in formSchemaTypeRepository.Get())
        {
            list.Add(new FormSchemaTypeViewModel()
            {
                Id = formSchemaType.Id,
                Title = formSchemaType.Title,
                IsActive = formSchemaType.IsActive,
                CreationDate = formSchemaType.CreationDate.ToShortDateString(),
            });
        }

        return list;
    }

    public FormSchemaTypeViewModel GetBy(int id)
    {
        var formSchemaType = formSchemaTypeRepository.GetBy(id);
        return new FormSchemaTypeViewModel()
        {
            Id = formSchemaType.Id,
            Title = formSchemaType.Title,
            IsActive = formSchemaType.IsActive,
            CreationDate = formSchemaType.CreationDate.ToShortDateString(),
        };
    }

    public void Add(NewFormSchemaTypeCommand command)
    {
        formSchemaTypeRepository.Add(new FormSchemaType(command.Title));
        formSchemaTypeRepository.Save();
    }

    public void Update(UpdateFormSchemaTypeCommand command)
    {
        formSchemaTypeRepository.GetBy(command.Id).Update(command.Title);
        formSchemaTypeRepository.Save();
    }

    public void Active(int formSchemaTypeId)
    {
        formSchemaTypeRepository.GetBy(formSchemaTypeId).Active();
        formSchemaTypeRepository.Save();
    }

    public void DeActive(int formSchemaTypeId)
    {
        formSchemaTypeRepository.GetBy(formSchemaTypeId).DeActive();
        formSchemaTypeRepository.Save();
    }
}
using Ticketing.Application.Contracts.FormSchema;
using Ticketing.Application.Contracts.FormSchema.Commands;
using Ticketing.Application.Contracts.FormSchema.ViewModels;
using Ticketing.Domain.FormSchemaAgg;
using Ticketing.Domain.FormSchemaAgg.Services;

namespace Ticketing.Application;

public class FormSchemaApplication : IFormSchemaApplication
{
    private readonly IFormSchemaRepository formSchemaRepository;
    private readonly IFormSchemaValidator formSchemaValidator;
    public FormSchemaApplication(IFormSchemaRepository formSchemaRepository, IFormSchemaValidator formSchemaValidator)
    {
        this.formSchemaRepository = formSchemaRepository;
        this.formSchemaValidator = formSchemaValidator;
    }

    public IList<FormSchemaViewModel> GetAll()
    {
        var list = new List<FormSchemaViewModel>();
        foreach (var formSchema in formSchemaRepository.Get())
        {
            list.Add(new FormSchemaViewModel()
            {
                Id = formSchema.Id,
                Title = formSchema.Title,
                Description = formSchema.Description,
                CreationDate = formSchema.CreationDate.ToShortDateString(),
                TypeId = formSchema.TypeId,
            });
        }

        return list;
    }

    public FormSchemaViewModel GetBy(int id)
    {
        var formSchema = formSchemaRepository.GetBy(id);
        return new FormSchemaViewModel()
        {
            Id = formSchema.Id,
            Title = formSchema.Title,
            Description = formSchema.Description,
            CreationDate = formSchema.CreationDate.ToShortDateString(),
            TypeId = formSchema.TypeId,
        };
    }

    public void Add(NewFormSchemaCommand command)
    {
        formSchemaRepository.Add(new FormSchema(command.Title, command.Description, command.TypeId, formSchemaValidator));
        formSchemaRepository.Save();
    }

    public void Update(UpdateFormSchemaCommand command)
    {
        formSchemaRepository.GetBy(command.Id).Update(command.Title, command.Description, formSchemaValidator);
        formSchemaRepository.Save();
    }

    public void Active(int formSchemaId)
    {
        formSchemaRepository.GetBy(formSchemaId).Active();
        formSchemaRepository.Save();
    }

    public void DeActive(int formSchemaId)
    {
        formSchemaRepository.GetBy(formSchemaId).DeActive();
        formSchemaRepository.Save();
    }
}
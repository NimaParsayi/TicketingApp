using System.Collections.Generic;
using Ticketing.Application.Contracts.Form;
using Ticketing.Application.Contracts.Form.Commands;
using Ticketing.Application.Contracts.Form.ViewModels;
using Ticketing.Domain.FormAgg;
using Ticketing.Domain.FormAgg.Services;

namespace Ticketing.Application;

public class FormApplication : IFormApplication
{
    private readonly IFormValidator formValidator;
    private readonly IFormRepository formRepository;
    public FormApplication(IFormValidator formValidator, IFormRepository formRepository)
    {
        this.formValidator = formValidator;
        this.formRepository = formRepository;
    }

    public IList<FormViewModel> GetAll()
    {
        var list = new List<FormViewModel>();
        foreach (var form in formRepository.Get())
        {
            list.Add(new FormViewModel()
            {
                Id = form.Id,
                Mobile = form.Mobile,
                Data = form.Data,
                CreationDate = form.CreationDate.ToShortDateString()
            });
        }
        return list;

    }

    public FormViewModel GetBy(int id)
    {
        var form = formRepository.GetBy(id);
        return new FormViewModel()
        {
            Id = form.Id,
            Mobile = form.Mobile,
            Data = form.Data,
            CreationDate = form.CreationDate.ToShortDateString()
        };
    }

    public IList<FormViewModel> GetBy(string mobile)
    {
        var list = new List<FormViewModel>();
        foreach (var form in formRepository.GetBy(mobile))
        {
            list.Add(new FormViewModel()
            {
                Id = form.Id,
                Mobile = form.Mobile,
                Data = form.Data,
                CreationDate = form.CreationDate.ToShortDateString()
            });
        }
        return list;
    }

    public void Add(AddFormCommand command)
    {
        formRepository.Add(new Form(command.Mobile, command.Data, formValidator));
        formRepository.Save();
    }
}

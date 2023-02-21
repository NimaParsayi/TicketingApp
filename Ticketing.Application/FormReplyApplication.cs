
using Ticketing.Application.Contracts.FormReply;
using Ticketing.Application.Contracts.FormReply.Commands;
using Ticketing.Application.Contracts.FormReply.ViewModels;
using Ticketing.Domain.FormReplyAgg;
using Ticketing.Domain.FormReplyAgg.Services;

namespace Ticketing.Application;

public class FormReplyApplication : IFormReplyApplication
{
    private readonly IFormReplyValidator formReplyValidator;
    private readonly IFormReplyRepository formReplyRepository;
    public FormReplyApplication(IFormReplyValidator formReplyValidator, IFormReplyRepository formReplyRepository)
    {
        this.formReplyValidator = formReplyValidator;
        this.formReplyRepository = formReplyRepository;
    }

    public IList<FormReplyViewModel> GetAll()
    {
        var list = new List<FormReplyViewModel>();
        foreach (var item in formReplyRepository.Get())
        {
            list.Add(new FormReplyViewModel()
            {
                Id = item.Id,
                CreationDate = item.CreationDate.ToShortDateString(),
                Message = item.Message,
                FormId = item.FormId,
                Mobile = item.Mobile,
                ReplyToMessageId = item.ReplyToMessageId,
            });
        }
        return list;
    }

    public FormReplyViewModel GetBy(long id)
    {
        var item = formReplyRepository.GetBy(id);
        return new FormReplyViewModel()
        {
            Id = item.Id,
            CreationDate = item.CreationDate.ToShortDateString(),
            Message = item.Message,
            FormId = item.FormId,
            Mobile = item.Mobile,
            ReplyToMessageId = item.ReplyToMessageId,
        };
    }

    public IList<FormReplyViewModel> GetBy(string mobile)
    {
        var list = new List<FormReplyViewModel>();
        foreach (var item in formReplyRepository.GetBy(mobile))
        {
            list.Add(new FormReplyViewModel()
            {
                Id = item.Id,
                CreationDate = item.CreationDate.ToShortDateString(),
                Message = item.Message,
                FormId = item.FormId,
                Mobile = item.Mobile,
                ReplyToMessageId = item.ReplyToMessageId,
            });
        }
        return list;
    }

    public IList<FormReplyViewModel> GetFormReplies(int id)
    {
        var list = new List<FormReplyViewModel>();
        foreach (var item in formReplyRepository.GetFormReplies(id))
        {
            list.Add(new FormReplyViewModel()
            {
                Id = item.Id,
                CreationDate = item.CreationDate.ToShortDateString(),
                Message = item.Message,
                FormId = item.FormId,
                Mobile = item.Mobile,
                ReplyToMessageId = item.ReplyToMessageId,
            });
        }
        return list;
    }

    public void Add(NewReplyCommand command)
    {
        formReplyRepository.Add(new FormReply(command.Message, command.Mobile, command.FormId, formReplyValidator, command.ReplyToMessageId));
        formReplyRepository.Save();
    }

    public void EditMessage(EditReplyMessageCommand command)
    {
        formReplyRepository.GetBy(command.Id).EditMessage(command.Message, formReplyValidator);
        formReplyRepository.Save();
    }

    public void UpdateMobile(EditReplyMobileCommand command)
    {
        formReplyRepository.GetBy(command.Id).EditMobile(command.Mobile, formReplyValidator);
        formReplyRepository.Save();
    }
}

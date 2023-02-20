using Ticketing.Application.Contracts.FormReply.Commands;
using Ticketing.Application.Contracts.FormReply.ViewModels;

namespace Ticketing.Application.Contracts.FormReply;

public interface IFormReplyApplication
{
    IList<FormReplyViewModel> GetAll();
    FormReplyViewModel GetBy(long id);
    IList<FormReplyViewModel> GetBy(string mobile);
    void Add(NewReplyCommand command);
    void EditMessage(EditReplyMessageCommand command);
    void UpdateMobile(EditReplyMobileCommand command);
}

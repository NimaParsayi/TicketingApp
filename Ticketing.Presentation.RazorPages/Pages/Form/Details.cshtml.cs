using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using Ticketing.Application.Contracts.Form;
using Ticketing.Application.Contracts.Form.ViewModels;
using Ticketing.Application.Contracts.FormReply;
using Ticketing.Application.Contracts.FormReply.Commands;

namespace Ticketing.Presentation.RazorPages.Pages.Form
{
    public class DetailsModel : PageModel
    {
        private readonly IFormApplication application;
        private readonly IFormReplyApplication replyApplication;
        public DetailsModel(IFormApplication application, IFormReplyApplication replyApplication)
        {
            this.application = application;
            this.replyApplication = replyApplication;
        }

        public FormViewModel Form { get; set; }
        public IDictionary<string, object> Fields { get; set; }
        [BindProperty]
        public NewReplyCommand Command { get; set; }

        public void OnGet(int id)
        {
            Form = application.GetBy(id);
            Fields = JsonConvert.DeserializeObject<IDictionary<string, object>>(Form.Data.ToString());
            Command = new NewReplyCommand();
        }

        public IActionResult OnPost()
        {
            replyApplication.Add(Command);
            return RedirectToPage("/Form/Index");
        }
    }
}

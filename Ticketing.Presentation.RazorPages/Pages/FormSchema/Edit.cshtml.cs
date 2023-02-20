using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ticketing.Application.Contracts.FormSchema.Commands;
using Ticketing.Application.Contracts.FormSchema;
using Ticketing.Application.Contracts.FormSchemaType.ViewModels;
using Ticketing.Application.Contracts.FormSchemaType;

namespace Ticketing.Presentation.RazorPages.Pages.FormSchema
{
    public class EditModel : PageModel
    {
        private readonly IFormSchemaApplication application;
        public EditModel(IFormSchemaApplication application)
        {
            this.application = application;
        }

        [BindProperty]
        public UpdateFormSchemaCommand Command { get; set; }

        public void OnGet(int id)
        {
            var formSchema = application.GetBy(id);
            Command = new UpdateFormSchemaCommand() { Id = formSchema.Id, Title = formSchema.Title, Description = formSchema.Description };
        }

        public IActionResult OnPost()
        {
            application.Update(Command);
            return RedirectToPage("/FormSchema/Index");
        }
    }
}

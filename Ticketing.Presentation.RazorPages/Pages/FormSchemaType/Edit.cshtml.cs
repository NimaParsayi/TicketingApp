using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ticketing.Application.Contracts.FormSchemaType.Commands;
using Ticketing.Application.Contracts.FormSchemaType;

namespace Ticketing.Presentation.RazorPages.Pages.FormSchemaType
{
    public class EditModel : PageModel
    {
        private readonly IFormSchemaTypeApplication application;
        public EditModel(IFormSchemaTypeApplication application)
        {
            this.application = application;
        }

        [BindProperty]
        public UpdateFormSchemaTypeCommand Command { get; set; }

        public void OnGet(int id)
        {
            var formSchemaType = application.GetBy(id);
            Command = new UpdateFormSchemaTypeCommand()
            {
                Id = id,
                Title = formSchemaType.Title
            };
        }

        public IActionResult OnPost()
        {
            application.Update(Command);
            return RedirectToPage("/FormSchemaType/Index");
        }
    }
}

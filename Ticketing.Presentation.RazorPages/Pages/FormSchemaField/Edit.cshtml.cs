using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ticketing.Application.Contracts.FormSchemaField;
using Ticketing.Application.Contracts.FormSchemaField.Commands;

namespace Ticketing.Presentation.RazorPages.Pages.FormSchemaField
{
    public class EditModel : PageModel
    {
        private readonly IFormSchemaFieldApplication application;
        public EditModel(IFormSchemaFieldApplication application)
        {
            this.application = application;
        }


        [BindProperty]
        public UpdateFormSchemaFieldCommand Command { get; set; }

        public void OnGet(int id)
        {
            var field = application.GetBy(id);
            Command = new UpdateFormSchemaFieldCommand()
            {
                Id = field.Id,
                Title = field.Title,
                Description = field.Description,
            };
        }

        public IActionResult OnPost()
        {
            application.Update(Command);
            return RedirectToPage("/FormSchemaField/Index");
        }
    }
}

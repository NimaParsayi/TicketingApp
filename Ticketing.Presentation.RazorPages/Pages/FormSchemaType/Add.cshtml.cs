using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ticketing.Application.Contracts.FormSchemaType;
using Ticketing.Application.Contracts.FormSchemaType.Commands;

namespace Ticketing.Presentation.RazorPages.Pages.FormSchemaType
{
    public class AddModel : PageModel
    {
        private readonly IFormSchemaTypeApplication application;
        public AddModel(IFormSchemaTypeApplication application)
        {
            this.application = application;
        }

        [BindProperty]
        public NewFormSchemaTypeCommand Command { get; set; }

        public void OnGet()
        {
            Command = new NewFormSchemaTypeCommand();
        }

        public IActionResult OnPost()
        {
            application.Add(Command);
            return RedirectToPage("/FormSchemaType/Index");
        }
    }
}

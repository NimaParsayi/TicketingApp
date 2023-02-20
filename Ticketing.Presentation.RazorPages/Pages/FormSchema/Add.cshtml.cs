using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ticketing.Application.Contracts.FormSchema;
using Ticketing.Application.Contracts.FormSchema.Commands;
using Ticketing.Application.Contracts.FormSchemaType;
using Ticketing.Application.Contracts.FormSchemaType.ViewModels;

namespace Ticketing.Presentation.RazorPages.Pages.FormSchema
{
    public class AddModel : PageModel
    {
        private readonly IFormSchemaApplication application;
        private readonly IFormSchemaTypeApplication typeApplication;
        public AddModel(IFormSchemaApplication application, IFormSchemaTypeApplication typeApplication)
        {
            this.application = application;
            this.typeApplication = typeApplication;
        }

        [BindProperty]
        public NewFormSchemaCommand Command { get; set; }

        public IList<FormSchemaTypeViewModel> Types { get; set; }

        public void OnGet()
        {
            Command = new NewFormSchemaCommand();
            Types = typeApplication.GetAll();
        }

        public IActionResult OnPost()
        {
            application.Add(Command);
            return RedirectToPage("/FormSchema/Index");
        }
    }
}

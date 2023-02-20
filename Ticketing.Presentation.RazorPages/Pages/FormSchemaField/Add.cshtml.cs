using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ticketing.Application.Contracts.FormSchema;
using Ticketing.Application.Contracts.FormSchema.ViewModels;
using Ticketing.Application.Contracts.FormSchemaField;
using Ticketing.Application.Contracts.FormSchemaField.Commands;

namespace Ticketing.Presentation.RazorPages.Pages.FormSchemaField
{
    public class AddModel : PageModel
    {
        private readonly IFormSchemaFieldApplication application;
        private readonly IFormSchemaApplication schemaApplication;
        public AddModel(IFormSchemaFieldApplication application, IFormSchemaApplication schemaApplication)
        {
            this.application = application;
            this.schemaApplication = schemaApplication;
        }

        [BindProperty]
        public NewFormSchemaFieldCommand Command { get; set; }
        public IList<FormSchemaViewModel> FormSchemas { get; set; }
        public Array FieldTypes { get; set; }

        public void OnGet()
        {
            Command = new NewFormSchemaFieldCommand();
            FormSchemas = schemaApplication.GetAll();
            FieldTypes = application.GetFieldTypes();
        }

        public IActionResult OnPost()
        {
            application.Add(Command);
            return RedirectToPage("/FormSchemaField/Index");
        }
    }
}

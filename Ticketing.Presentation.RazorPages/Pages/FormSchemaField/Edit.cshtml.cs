using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Ticketing.Application.Contracts.FormSchema;
using Ticketing.Application.Contracts.FormSchemaField;
using Ticketing.Application.Contracts.FormSchemaField.Commands;

namespace Ticketing.Presentation.RazorPages.Pages.FormSchemaField
{
    public class EditModel : PageModel
    {
        private readonly IFormSchemaFieldApplication application;
        private readonly IFormSchemaApplication schemaApplication;
        public EditModel(IFormSchemaFieldApplication application, IFormSchemaApplication schemaApplication)
        {
            this.application = application;
            this.schemaApplication = schemaApplication;
        }


        [BindProperty]
        public UpdateFormSchemaFieldCommand Command { get; set; }
        [BindProperty]
        public List<SelectListItem> FieldTypes { get; set; }

        public void OnGet(int id)
        {
            var ft = new List<string>();
            ft.AddRange((string[])application.GetFieldTypes());

            var field = application.GetBy(id);
            Command = new UpdateFormSchemaFieldCommand()
            {
                Id = field.Id,
                Title = field.Title,
                Description = field.Description,
                Type = ft.IndexOf(ft.FirstOrDefault(x=>x == field.Type))
            };
            FieldTypes = ft.Select((value, index) => new SelectListItem { Text = value, Value = index.ToString()}).ToList();
        }

        public IActionResult OnPost()
        {
            application.Update(Command);
            return RedirectToPage("/FormSchemaField/Index");
        }
    }
}

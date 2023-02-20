using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ticketing.Application.Contracts.Form;
using Ticketing.Application.Contracts.FormSchema;
using Ticketing.Application.Contracts.FormSchema.ViewModels;

namespace Ticketing.Presentation.RazorPages.Pages.Form
{
    public class FillModel : PageModel
    {
        private readonly IFormApplication application;
        private readonly IFormSchemaApplication schemaApplication;
        public FillModel(IFormApplication application, IFormSchemaApplication schemaApplication)
        {
            this.application = application;
            this.schemaApplication = schemaApplication;
        }

        [BindProperty]
        public FormSchemaStructureViewModel Structure { get; set; }

        public void OnGet(int id)
        {
            Structure = schemaApplication.GetFormStructure(id);
        }
    }
}

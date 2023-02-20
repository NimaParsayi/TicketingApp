using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ticketing.Application.Contracts.FormSchema;
using Ticketing.Application.Contracts.FormSchema.ViewModels;

namespace Ticketing.Presentation.RazorPages.Pages.FormSchema
{
    public class IndexModel : PageModel
    {
        private readonly IFormSchemaApplication application;
        public IndexModel(IFormSchemaApplication application)
        {
            this.application = application;
        }

        public IList<FormSchemaViewModel> FormSchemas { get; set; }

        public void OnGet()
        {
            FormSchemas = application.GetAll();
        }
    }
}

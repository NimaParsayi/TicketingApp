using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ticketing.Application.Contracts.FormSchemaField;
using Ticketing.Application.Contracts.FormSchemaField.ViewModels;

namespace Ticketing.Presentation.RazorPages.Pages.FormSchemaField
{
    public class IndexModel : PageModel
    {
        private readonly IFormSchemaFieldApplication application;
        public IndexModel(IFormSchemaFieldApplication application)
        {
            this.application = application;
        }

        public IList<FormSchemaFieldViewModel> FormSchemaFields { get; set; }

        public void OnGet()
        {
            FormSchemaFields = application.GetAll();
        }
    }
}

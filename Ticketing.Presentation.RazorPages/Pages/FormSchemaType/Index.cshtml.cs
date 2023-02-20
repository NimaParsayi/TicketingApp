using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ticketing.Application.Contracts.FormSchemaType;
using Ticketing.Application.Contracts.FormSchemaType.ViewModels;

namespace Ticketing.Presentation.RazorPages.Pages.FormSchemaType
{
    public class IndexModel : PageModel
    {
        private readonly IFormSchemaTypeApplication application;
        public IndexModel(IFormSchemaTypeApplication application)
        {
            this.application = application;
        }

        public IList<FormSchemaTypeViewModel> FormSchemaType { get; set; }

        public void OnGet()
        {
            FormSchemaType = application.GetAll();
        }
    }
}

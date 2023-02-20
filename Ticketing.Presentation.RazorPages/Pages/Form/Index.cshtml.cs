using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ticketing.Application.Contracts.Form;
using Ticketing.Application.Contracts.Form.ViewModels;

namespace Ticketing.Presentation.RazorPages.Pages.Form
{
    public class IndexModel : PageModel
    {
        private readonly IFormApplication application;
        public IndexModel(IFormApplication application)
        {
            this.application = application;
        }

        internal IList<FormViewModel> Forms { get; set; }

        public void OnGet()
        {
            Forms = application.GetAll();
        }
    }
}

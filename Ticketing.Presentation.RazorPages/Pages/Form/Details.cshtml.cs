using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ticketing.Application.Contracts.Form;
using Ticketing.Application.Contracts.Form.ViewModels;

namespace Ticketing.Presentation.RazorPages.Pages.Form
{
    public class DetailsModel : PageModel
    {
        private readonly IFormApplication application;
        public DetailsModel(IFormApplication application)
        {
            this.application = application;
        }

        public FormViewModel Form { get; set; }

        public void OnGet(int id)
        {
            Form = application.GetBy(id);
        }
    }
}

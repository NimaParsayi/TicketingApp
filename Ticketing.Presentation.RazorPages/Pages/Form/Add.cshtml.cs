using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Ticketing.Application.Contracts.Form;
using Ticketing.Application.Contracts.Form.ViewModels;
using Ticketing.Application.Contracts.FormSchemaType;
using Ticketing.Application.Contracts.FormSchemaType.ViewModels;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Net.Mime.MediaTypeNames;

namespace Ticketing.Presentation.RazorPages.Pages.Form
{
    public class AddModel : PageModel
    {
        private readonly IFormSchemaTypeApplication typeApplication;
        public AddModel(IFormSchemaTypeApplication typeApplication)
        {
            this.typeApplication = typeApplication;
        }
        [BindProperty]
        public int SelectedType { get; set; }
        [BindProperty]
        public List<SelectListItem> Types { get; set; }

        public void OnGet()
        {
            Types = typeApplication.GetAll().Select((value, index) => new SelectListItem { Text = value.Title, Value = index.ToString() }).ToList();
        }

        public IActionResult OnPost()
        {
            return RedirectToPage("/Form/Fill", new { @id = SelectedType });
        }
    }
}

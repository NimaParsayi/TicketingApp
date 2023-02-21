using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Dynamic;
using System.Linq;
using Ticketing.Application.Contracts.Form;
using Ticketing.Application.Contracts.Form.Commands;
using Ticketing.Application.Contracts.FormSchema;
using Ticketing.Application.Contracts.FormSchema.Commands;
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

        [BindProperty]
        public AddFormCommand Command { get; set; }

        public void OnGet(int id)
        {
            Structure = schemaApplication.GetFormStructure(id);
        }

        public IActionResult OnPost()
        {
            var fieldsInForm = Request.Form.Keys;
            ExpandoObject obj = new ExpandoObject();
            var fields = (IDictionary<string, object>)obj;
            foreach (var field in fieldsInForm)
            {
                if (field == "Command.Mobile") continue;
                else if (field == "__RequestVerificationToken") continue;

                fields.Add(field, Request.Form[field][0]);
            }
            Command.Data = JsonConvert.SerializeObject(obj);
            application.Add(Command);
            return RedirectToPage("/Form/Index");
        }
    }
}

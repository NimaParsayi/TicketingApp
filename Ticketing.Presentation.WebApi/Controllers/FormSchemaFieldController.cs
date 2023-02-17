using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ticketing.Application.Contracts.FormSchema.Commands;
using Ticketing.Application.Contracts.FormSchema.ViewModels;
using Ticketing.Application.Contracts.FormSchemaField;
using Ticketing.Application.Contracts.FormSchemaField.Commands;
using Ticketing.Application.Contracts.FormSchemaField.ViewModels;

namespace Ticketing.Presentation.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormSchemaFieldController : ControllerBase
    {
        private readonly IFormSchemaFieldApplication application;
        public FormSchemaFieldController(IFormSchemaFieldApplication application)
        {
            this.application = application;
        }

        [HttpGet]
        public IList<FormSchemaFieldViewModel> GetAll() => application.GetAll();

        [HttpGet("{id}")]
        public FormSchemaFieldViewModel Get(int id) => application.GetBy(id);

        [HttpGet("Types")]
        public Array GetFieldTypes() => application.GetFieldTypes();

        [HttpPost]
        public void Add([FromBody] NewFormSchemaFieldCommand command) => application.Add(command);

        [HttpPost("Update")]
        public void Update([FromBody] UpdateFormSchemaFieldCommand command) => application.Update(command);

        [HttpPost("Active/{id}")]
        public void Active(int id) => application.Active(id);

        [HttpPost("DeActive/{id}")]
        public void DeActive(int id) => application.DeActive(id);
    }
}

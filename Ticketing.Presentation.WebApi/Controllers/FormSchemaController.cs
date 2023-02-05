using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ticketing.Application.Contracts.FormSchema;
using Ticketing.Application.Contracts.FormSchema.Commands;
using Ticketing.Application.Contracts.FormSchema.ViewModels;

namespace Ticketing.Presentation.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormSchemaController : ControllerBase
    {
        private readonly IFormSchemaApplication application;
        public FormSchemaController(IFormSchemaApplication application)
        {
            this.application = application;
        }

        [HttpGet]
        public IList<FormSchemaViewModel> GetAll() => application.GetAll();

        [HttpGet("{id}")]
        public FormSchemaViewModel Get(int id) => application.GetBy(id);

        [HttpPost]
        public void Add([FromBody] NewFormSchemaCommand command) => application.Add(command);

        [HttpPost("Update")]
        public void Update([FromBody] UpdateFormSchemaCommand command) => application.Update(command);

        [HttpPost("Active/{id}")]
        public void Active(int id) => application.Active(id);

        [HttpPost("DeActive/{id}")]
        public void DeActive(int id) => application.DeActive(id);
    }
}

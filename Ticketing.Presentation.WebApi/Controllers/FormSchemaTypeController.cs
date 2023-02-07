using Microsoft.AspNetCore.Mvc;
using Ticketing.Application.Contracts.FormSchemaType;
using Ticketing.Application.Contracts.FormSchemaType.Commands;
using Ticketing.Application.Contracts.FormSchemaType.ViewModels;

namespace Ticketing.Presentation.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormSchemaTypeController : ControllerBase
    {
        private readonly IFormSchemaTypeApplication application;
        public FormSchemaTypeController(IFormSchemaTypeApplication application)
        {
            this.application = application;
        }

        [HttpGet]
        public IList<FormSchemaTypeViewModel> GetAll() => application.GetAll();

        [HttpGet("{id}")]
        public FormSchemaTypeViewModel Get(int id) => application.GetBy(id);

        [HttpPost]
        public void Add([FromBody] NewFormSchemaTypeCommand command) => application.Add(command);

        [HttpPost("Update")]
        public void Update([FromBody] UpdateFormSchemaTypeCommand command) => application.Update(command);

        [HttpPost("Active/{id}")]
        public void Active(int id) => application.Active(id);

        [HttpPost("DeActive/{id}")]
        public void DeActive(int id) => application.DeActive(id);
    }
}

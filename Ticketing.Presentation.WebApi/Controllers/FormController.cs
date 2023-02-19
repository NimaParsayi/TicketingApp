using Microsoft.AspNetCore.Mvc;
using Ticketing.Application.Contracts.Form;
using Ticketing.Application.Contracts.Form.Commands;
using Ticketing.Application.Contracts.Form.ViewModels;

namespace Ticketing.Presentation.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormController : ControllerBase
    {
        private readonly IFormApplication application;
        public FormController(IFormApplication application)
        {
            this.application = application;
        }

        [HttpGet]
        IList<FormViewModel> GetAll() => application.GetAll();

        [HttpGet("{id}")]
        FormViewModel Get(int id) => application.GetBy(id);


        [HttpGet("{mobile}")]
        IList<FormViewModel> Get(string mobile) => application.GetBy(mobile);

        [HttpPost]
        void Add([FromBody] AddFormCommand command) => application.Add(command);
    }
}

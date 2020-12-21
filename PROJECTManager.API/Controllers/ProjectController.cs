using MediatR;
using Microsoft.AspNetCore.Mvc;
using PROJECTManager.Domain.Models.RequestModels.CommandRequestModels;
using PROJECTManager.Domain.Models.RequestModels.QueryRequestModels;
using System.Threading.Tasks;

namespace PROJECTManager.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IMediator mediator;

        public ProjectController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllProjectsByCreateDateRequestModel requestModel)
        {
            var responseModel = await mediator.Send(requestModel);

            return Ok(responseModel);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> Get([FromRoute] GetProjectByIdRequestModel requestModel)
        {
            var responseModel = await mediator.Send(requestModel);

            return Ok(responseModel);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddProjectRequestModel requestModel)
        {
            var responseModel = await mediator.Send(requestModel);

            return Ok(responseModel);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UpdateProjectRequestModel requestModel)
        {
            await mediator.Send(requestModel);

            return Ok("Updated successfully");
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteProjectRequestModel requestModel)
        {
            await mediator.Send(requestModel);

            return Ok("Deleted successfully");
        }
    }
}

namespace FootballTournamentSystem.Person.Web
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Core.Web;
    using FootballTournamentSystem.Person.Application.Features.President.Commands.Create;

    [ApiController]
    [Route("[controller]")]
    public class PresidentController : ApiController
    {
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<CreatePresidentOutputModel>> Create(
            CreatePresidentCommand command)
            => await this.Send(command);
    }
}

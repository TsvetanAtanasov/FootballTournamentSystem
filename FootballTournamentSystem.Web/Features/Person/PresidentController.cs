namespace FootballTournamentSystem.Web.Features.Person
{
    using Application.Features.PersonContext.President.Commands.Create;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

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

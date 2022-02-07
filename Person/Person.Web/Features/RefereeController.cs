namespace FootballTournamentSystem.Person.Web
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Core.Web;
    using FootballTournamentSystem.Person.Application.Features.Referee.Commands.Create;

    [ApiController]
    [Route("[controller]")]
    public class RefereeController : ApiController
    {
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<CreateRefereeOutputModel>> Create(
            CreateRefereeCommand command)
            => await this.Send(command);
    }
}

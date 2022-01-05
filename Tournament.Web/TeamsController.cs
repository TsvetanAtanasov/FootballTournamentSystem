namespace FootballTournamentSystem.Tournament.Web
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using Core.Web;
    using FootballTournamentSystem.Tournament.Application.Features.Team.Commands.Create;

    [ApiController]
    [Route("[controller]")]
    public class TeamsController : ApiController
    {
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<CreateTeamOutputModel>> Create(
            CreateTeamCommand command)
            => await this.Send(command);
    }
}

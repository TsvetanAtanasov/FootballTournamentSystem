namespace FootballTournamentSystem.Web.Features.Tournament
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using Application.Features.TournamentContext.Team.Commands.Create;

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

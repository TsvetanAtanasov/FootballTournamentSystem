namespace FootballTournamentSystem.Tournament.Web
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using Core.Web;
    using FootballTournamentSystem.Tournament.Application.Features.Team.Commands.Create;
    using FootballTournamentSystem.Tournament.Application.Features.Team.Common;
    using global::Tournament.Application.Features.Team.Queries;

    [ApiController]
    [Route("[controller]")]
    public class TeamsController : ApiController
    {
        [HttpPost]
        [Authorize]
        [Route(nameof(Create))]
        public async Task<ActionResult<CreateTeamOutputModel>> Create(
            CreateTeamCommand command)
            => await this.Send(command);

        [HttpGet]
        [Route(nameof(TeamById))]
        public async Task<ActionResult<TeamOutputModel>> TeamById(
            [FromQuery] GetTeamByIdQuery query)
            => await this.Send(query);
    }
}

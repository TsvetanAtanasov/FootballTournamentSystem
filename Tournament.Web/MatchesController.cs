namespace FootballTournamentSystem.Tournament.Web
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using Core.Web;
    using FootballTournamentSystem.Tournament.Application.Features.Match.Commands.Create;
    using FootballTournamentSystem.Tournament.Application.Features.Match.Commands.AddRefereeToMatch;

    [ApiController]
    [Route("[controller]")]
    public class MatchesController : ApiController
    {
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<CreateMatchOutputModel>> Create(
            CreateMatchCommand command)
            => await this.Send(command);

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<AddRefereeToMatchOutputModel>> AddRefereeToMatch(
            AddRefereeToMatchCommand command)
            => await this.Send(command);
    }
}

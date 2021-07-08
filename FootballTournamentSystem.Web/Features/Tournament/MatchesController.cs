namespace FootballTournamentSystem.Web.Features.Tournament
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using Application.Features.TournamentContext.Match.Commands.Create;
    using Application.Features.TournamentContext.Match.Commands.AddRefereeToMatch;

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

namespace FootballTournamentSystem.Tournament.Web
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using Core.Web;
    using FootballTournamentSystem.Tournament.Application.Features.Tournament.Commands.Create;
    using FootballTournamentSystem.Tournament.Application.Features.Tournament.Commands.Delete;
    using FootballTournamentSystem.Tournament.Application.Features.Tournament.Commands.TournamentGroups.AddGroupToTournament;
    using FootballTournamentSystem.Tournament.Application.Features.Tournament.Common;
    using FootballTournamentSystem.Tournament.Application.Features.Tournament.Queries.All;
    using FootballTournamentSystem.Tournament.Application.Features.Tournament.Queries.TournamentGroups;
    using FootballTournamentSystem.Tournament.Application.Features.Tournament.Queries.TournamentGroups.GroupMatches;
    using FootballTournamentSystem.Tournament.Application.Features.Team.Common;
    using FootballTournamentSystem.Tournament.Application.Features.Tournament.Queries.TournamentGroups.GroupTeams;
    using FootballTournamentSystem.Tournament.Application.Features.Tournament.Queries.TournamentMatches;
    using FootballTournamentSystem.Tournament.Application.Features.Tournament.Queries.TournamentTeams;

    [ApiController]
    [Route("[controller]")]
    public class TournamentsController : ApiController
    {
        [HttpPost]
        [Authorize]
        [Route(nameof(Create))]
        public async Task<ActionResult<CreateTournamentOutputModel>> Create(
            dynamic data)
        {
            // TODO: change code after testing
            var command = new CreateTournamentCommand(32, "https://static01.nyt.com/images/2022/04/01/multimedia/world-cup-draw-tracker/world-cup-draw-tracker-mediumSquareAt3X.jpg");
            return await this.Send(command);
        }

        [HttpDelete]
        [Authorize]
        [Route(Id)]
        public async Task<ActionResult> Delete(
            [FromRoute] DeleteTournamentCommand command)
            => await this.Send(command);
        
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<AddGroupToTournamentOutputModel>> AddGroupToTournament(
            AddGroupToTournamentCommand command)
            => await this.Send(command);

        [HttpGet]
        [Route(nameof(All))]
        public async Task<ActionResult<IEnumerable<TournamentOutputModel>>> All(
            [FromQuery] GetAllTournamentsQuery query)
            => await this.Send(query);

        [HttpGet]
        [Route(nameof(Groups))]
        public async Task<ActionResult<IEnumerable<GetTournamentGroupOutputModel>>> Groups(
            [FromQuery] GetTournamentGroupsQuery query)
            => await this.Send(query);

        [HttpGet]
        [Route(nameof(GroupMatches))]
        public async Task<ActionResult<IEnumerable<GetGroupMatchOutputModel>>> GroupMatches(
            [FromQuery] GetGroupMatchesQuery query)
            => await this.Send(query);

        [HttpGet]
        [Route(nameof(GroupTeams))]
        public async Task<ActionResult<IEnumerable<TeamOutputModel>>> GroupTeams(
            [FromQuery] GetGroupTeamsQuery query)
            => await this.Send(query);

        [HttpGet]
        [Route(nameof(TournamentMatches))]
        public async Task<ActionResult<IEnumerable<GetTournamentMatchOutputModel>>> TournamentMatches(
            [FromQuery] GetTournamentMatchesQuery query)
            => await this.Send(query);

        [HttpGet]
        [Route(nameof(TournamentTeams))]
        public async Task<ActionResult<IEnumerable<TeamOutputModel>>> TournamentTeams(
            [FromQuery] GetTournamentTeamsQuery query)
            => await this.Send(query);
    }
}

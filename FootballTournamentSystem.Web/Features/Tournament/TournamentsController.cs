namespace FootballTournamentSystem.Web.Features.Tournament
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using Application.Features.Tournament.Tournament.Commands.Create;
    using Application.Features.Tournament.Tournament.Commands.Delete;
    using Application.Features.Tournament.Tournament.Commands.TournamentGroups.AddGroupToTournament;
    using Application.Features.Tournament.Tournament.Queries.TournamentGroups.GroupMatches;
    using Application.Features.Tournament.Tournament.Queries.TournamentGroups;
    using Application.Features.Tournament.Tournament.Queries.TournamentGroups.GroupTeams;
    using Application.Features.Tournament.Team.Common;
    using Application.Features.Tournament.Tournament.Queries.TournamentMatches;
    using Application.Features.Tournament.Tournament.Queries.TournamentTeams;
    using FootballTournamentSystem.Application.Features.Tournament.Tournament.Queries.All;
    using FootballTournamentSystem.Application.Features.Tournament.Tournament.Common;

    [ApiController]
    [Route("[controller]")]
    public class TournamentsController : ApiController
    {
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<CreateTournamentOutputModel>> Create(
            CreateTournamentCommand command)
            => await this.Send(command);

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

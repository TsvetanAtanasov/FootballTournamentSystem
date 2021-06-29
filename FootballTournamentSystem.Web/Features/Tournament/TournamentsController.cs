namespace FootballTournamentSystem.Web.Features.TournamentContext
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using Application.Features.TournamentContext.Tournament.Commands.Create;
    using Application.Features.TournamentContext.Tournament.Commands.Delete;
    using Application.Features.TournamentContext.Tournament.Commands.TournamentGroups.AddGroupToTournament;
    using Application.Features.TournamentContext.Tournament.Queries.TournamentGroups.GroupMatches;
    using Application.Features.TournamentContext.Tournament.Queries.TournamentGroups;
    using Application.Features.TournamentContext.Tournament.Queries.TournamentGroups.GroupTeams;
    using Application.Features.TournamentContext.Team.Common;
    using Application.Features.TournamentContext.Tournament.Queries.TournamentMatches;
    using Application.Features.TournamentContext.Tournament.Queries.TournamentTeams;

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
        public async Task<ActionResult<IEnumerable<GetGroupMatchOutputModel>>> All(
            [FromQuery] GetGroupMatchesQuery query)
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

namespace FootballTournamentSystem.Web.Features.TournamentContext
{
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("[controller]")]
    public class TournamentsController : ApiController
    {
        // TODO: Finish controller (use commands and output models from applications)
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<CreateCarAdOutputModel>> Create(
            CreateCarAdCommand command)
            => await this.Send(command);

        [HttpDelete]
        [Authorize]
        [Route(Id)]
        public async Task<ActionResult> Delete(
            [FromRoute] DeleteCarAdCommand command)
            => await this.Send(command);
        
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<CreateCarAdOutputModel>> AddGroupToTournament(
            CreateCarAdCommand command)
            => await this.Send(command);

        [HttpGet]
        [Route(nameof(All))]
        public async Task<ActionResult<IEnumerable<GetCarAdCategoryOutputModel>>> All(
            [FromQuery] GetCarAdCategoriesQuery query)
            => await this.Send(query);

        [HttpGet]
        [Route(nameof(Groups))]
        public async Task<ActionResult<IEnumerable<GetCarAdCategoryOutputModel>>> Groups(
            [FromQuery] GetCarAdCategoriesQuery query)
            => await this.Send(query);

        [HttpGet]
        [Route(nameof(GroupMatches))]
        public async Task<ActionResult<IEnumerable<GetCarAdCategoryOutputModel>>> GroupMatches(
            [FromQuery] GetCarAdCategoriesQuery query)
            => await this.Send(query);

        [HttpGet]
        [Route(nameof(GroupTeams))]
        public async Task<ActionResult<IEnumerable<GetCarAdCategoryOutputModel>>> GroupTeams(
            [FromQuery] GetCarAdCategoriesQuery query)
            => await this.Send(query);

        [HttpGet]
        [Route(nameof(TournamentMatches))]
        public async Task<ActionResult<IEnumerable<GetCarAdCategoryOutputModel>>> TournamentMatches(
            [FromQuery] GetCarAdCategoriesQuery query)
            => await this.Send(query);

        [HttpGet]
        [Route(nameof(TournamentTeams))]
        public async Task<ActionResult<IEnumerable<GetCarAdCategoryOutputModel>>> TournamentTeams(
            [FromQuery] GetCarAdCategoriesQuery query)
            => await this.Send(query);
    }
}

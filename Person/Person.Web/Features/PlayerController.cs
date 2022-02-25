namespace FootballTournamentSystem.Person.Web
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Core.Web;
    using FootballTournamentSystem.Person.Application.Features.Player.Commands.Create;
    using global::Person.Application.Features.Player.Queries;

    [ApiController]
    [Route("[controller]")]
    public class PlayerController : ApiController
    {
        [HttpPost]
        [Route(nameof(Create))]
        [Authorize]
        public async Task<ActionResult<CreatePlayerOutputModel>> Create(
            CreatePlayerCommand command)
            => await this.Send(command);

        [HttpGet]
        [Route(nameof(PlayerById))]
        public async Task<ActionResult<GetPlayerByIdOutputModel>> PlayerById(
            [FromQuery] GetPlayerByIdQuery query)
            => await this.Send(query);
    }
}

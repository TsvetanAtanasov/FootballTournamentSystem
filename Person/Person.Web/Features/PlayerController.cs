namespace FootballTournamentSystem.Person.Web
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Core.Web;
    using FootballTournamentSystem.Person.Application.Features.Player.Commands.Create;

    [ApiController]
    [Route("[controller]")]
    public class PlayerController : ApiController
    {
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<CreatePlayerOutputModel>> Create(
            CreatePlayerCommand command)
            => await this.Send(command);
    }
}

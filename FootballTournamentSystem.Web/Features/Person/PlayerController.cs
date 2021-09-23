namespace FootballTournamentSystem.Web.Features.Person
{
    using Application.Features.Person.Player.Commands.Create;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

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

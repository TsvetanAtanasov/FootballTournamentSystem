namespace FootballTournamentSystem.Web.Features.Person
{
    using Application.Features.Person.Referee.Commands.Create;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    [ApiController]
    [Route("[controller]")]
    public class RefereeController : ApiController
    {
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<CreateRefereeOutputModel>> Create(
            CreateRefereeCommand command)
            => await this.Send(command);
    }
}

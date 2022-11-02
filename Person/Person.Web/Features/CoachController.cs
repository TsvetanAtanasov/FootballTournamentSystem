namespace FootballTournamentSystem.Person.Web
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Core.Web;
    using FootballTournamentSystem.Person.Application.Features.Coach.Commands.Create;

    [ApiController]
    [Route("[controller]")]
    public class CoachController : ApiController
    {
        [HttpPost]
        [Authorize]
        [Route(nameof(Create))]
        public async Task<ActionResult<CreateCoachOutputModel>> Create(
            CreateCoachCommand command)
            => await this.Send(command);
    }
}

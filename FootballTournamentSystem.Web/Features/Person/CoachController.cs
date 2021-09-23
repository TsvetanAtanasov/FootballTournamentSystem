namespace FootballTournamentSystem.Web.Features.Person
{
    using Application.Features.Person.Coach.Commands.Create;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    [ApiController]
    [Route("[controller]")]
    public class CoachController : ApiController
    {
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<CreateCoachOutputModel>> Create(
            CreateCoachCommand command)
            => await this.Send(command);
    }
}

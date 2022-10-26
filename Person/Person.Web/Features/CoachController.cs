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
        public async Task<ActionResult<CreateCoachOutputModel>> Create()
        {
            var command = new CreateCoachCommand("Carlo", "Ancelotti", "https://d2x51gyc4ptf2q.cloudfront.net/content/uploads/2022/05/28021608/Real-Madrid-manager-Carlo-Ancelotti-issues-tactical-instructions.jpg", 4);
            return await this.Send(command);
        }
    }
}

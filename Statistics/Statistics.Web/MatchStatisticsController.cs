namespace FootballTournamentSystem.Statistics.Web
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using Core.Web;
    using FootballTournamentSystem.Statistics.Application.Features.MatchStatistics.Commands.Create;

    [ApiController]
    [Route("[controller]")]
    public class MatchStatisticsController : ApiController
    {
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<CreateMatchStatisticsOutputModel>> Create(
            CreateMatchStatisticsCommand command)
            => await this.Send(command);
    }
}

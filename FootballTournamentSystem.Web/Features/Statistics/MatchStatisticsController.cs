namespace FootballTournamentSystem.Web.Features.Statistics
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using FootballTournamentSystem.Application.Features.StatisticsContext.MatchStatistics.Create;

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

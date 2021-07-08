namespace FootballTournamentSystem.Web.Features.Statistics
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using Application.Features.StatisticsContext.PlayerStatistics.CreatePlayerStatisticsForMatch;
    using Application.Features.StatisticsContext.PlayerStatistics.Common;
    using Application.Features.StatisticsContext.PlayerStatistics.CreatePlayerStatisticsForPlayer;

    [ApiController]
    [Route("[controller]")]
    public class PlayerStatisticsController : ApiController
    {
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<CreatePlayerStatisticsOutputModel>> CreatePlayerStatisticsForMatch(
            CreatePlayerStatisticsForMatchCommand command)
            => await this.Send(command);

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<CreatePlayerStatisticsOutputModel>> CreatePlayerStatisticsForPlayer(
            CreatePlayerStatisticsForPlayerCommand command)
            => await this.Send(command);
    }
}

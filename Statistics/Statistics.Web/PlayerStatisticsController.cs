namespace FootballTournamentSystem.Statistics.Web
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using Core.Web;
    using FootballTournamentSystem.Statistics.Application.Features.PlayerStatistics.Common;
    using FootballTournamentSystem.Statistics.Application.Features.PlayerStatistics.CreatePlayerStatisticsForMatch;
    using FootballTournamentSystem.Statistics.Application.Features.PlayerStatistics.CreatePlayerStatisticsForPlayer;

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

namespace FootballTournamentSystem.Statistics.Web
{
    using Core.Web;
    using FootballTournamentSystem.Statistics.Application.Features.TournamentStatistics.Commands.Create;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    [ApiController]
    [Route("[controller]")]
    public class TournamentStatisticsController : ApiController
    {
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<CreateTournamentStatisticsOutputModel>> Create(
            CreateTournamentStatisticsCommand command)
            => await this.Send(command);
    }
}

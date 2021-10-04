namespace FootballTournamentSystem.Web.Features.Statistics
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using Application.Features.Statistics.TournamentStatistics.Create;

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

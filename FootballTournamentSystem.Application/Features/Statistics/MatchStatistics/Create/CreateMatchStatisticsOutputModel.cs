namespace FootballTournamentSystem.Application.Features.StatisticsContext.MatchStatistics.Create
{
    public class CreateMatchStatisticsOutputModel
    {
        public CreateMatchStatisticsOutputModel(int matchStatisticsId)
        {
            this.MatchStatisticsId = matchStatisticsId;
        }

        public int MatchStatisticsId { get; }
    }
}

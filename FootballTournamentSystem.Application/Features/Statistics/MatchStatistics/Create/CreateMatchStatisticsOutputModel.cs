namespace FootballTournamentSystem.Application.Features.Statistics.MatchStatistics.Create
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

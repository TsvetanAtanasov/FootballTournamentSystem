namespace FootballTournamentSystem.Statistics.Application.Features.MatchStatistics.Commands.Create
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

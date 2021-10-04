namespace FootballTournamentSystem.Application.Features.Statistics.PlayerStatistics.Common
{
    public class CreatePlayerStatisticsOutputModel
    {
        public CreatePlayerStatisticsOutputModel(int playerStatisticsId)
        {
            this.PlayerStatisticsId = playerStatisticsId;
        }

        public int PlayerStatisticsId { get; }
    }
}

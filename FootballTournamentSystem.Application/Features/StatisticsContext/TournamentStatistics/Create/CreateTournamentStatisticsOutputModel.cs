namespace FootballTournamentSystem.Application.Features.StatisticsContext.TournamentStatistics.Create
{
    public class CreateTournamentStatisticsOutputModel
    {
        public CreateTournamentStatisticsOutputModel(int tournamentStatisticsId)
        {
            this.TournamentStatisticsId = tournamentStatisticsId;
        }

        public int TournamentStatisticsId { get; }
    }
}

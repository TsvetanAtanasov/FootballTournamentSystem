namespace FootballTournamentSystem.Statistics.Application.Features.TournamentStatistics.Commands.Create
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

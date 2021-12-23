namespace FootballTournamentSystem.Application.Features.Statistics.TournamentStatistics.Create
{
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;
    using Domain.Factories.Statistics.TournamentStatistics;

    public class CreateTournamentStatisticsCommand : IRequest<CreateTournamentStatisticsOutputModel>
    {
        public CreateTournamentStatisticsCommand(int goalsScored, int goalScorerId, int winnerTeamId, int tournamentId)
        {
            this.GoalsScored = goalsScored;
            this.GoalScorerId = goalScorerId;
            this.WinnerTeamId = winnerTeamId;
            this.TournamentId = tournamentId;
        }

        public int GoalsScored { get; }

        public int GoalScorerId { get; }

        public int WinnerTeamId { get; }

        public int TournamentId { get; }

        public class CreateTournamentStatisticsCommandHandler : IRequestHandler<CreateTournamentStatisticsCommand, CreateTournamentStatisticsOutputModel>
        {
            private readonly ITournamentStatisticsRepository tournamentStatisticsRepository;
            private readonly ITournamentStatisticsFactory tournamentStatisticsFactory;

            public CreateTournamentStatisticsCommandHandler(
                ITournamentStatisticsRepository tournamentStatisticsRepository,
                ITournamentStatisticsFactory tournamentStatisticsFactory)
            {
                this.tournamentStatisticsRepository = tournamentStatisticsRepository;
                this.tournamentStatisticsFactory = tournamentStatisticsFactory;
            }

            public async Task<CreateTournamentStatisticsOutputModel> Handle(CreateTournamentStatisticsCommand request, CancellationToken cancellationToken)
            {
                var tournamentStatistics = this.tournamentStatisticsFactory
                    .WithGoalsScored(request.GoalsScored)
                    .Build();

                tournamentStatistics.AddGoalScorer(request.GoalScorerId);
                tournamentStatistics.AddWinnerTeam(request.WinnerTeamId);

                await this.tournamentStatisticsRepository.Save(tournamentStatistics, cancellationToken);
                // TODO: add event
                //var tournament = await this.tournamentRepository.GetTournamentById(request.TournamentId);
                //tournament.AddTournamentStatistics(tournamentStatistics.Id);

                return new CreateTournamentStatisticsOutputModel(tournamentStatistics.Id);
            }
        }
    }
}

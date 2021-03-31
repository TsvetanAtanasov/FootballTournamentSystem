namespace FootballTournamentSystem.Application.Features.StatisticsContext.TournamentStatistics.Create
{
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;
    using Domain.Factories.PersonContext.President;
    using Domain.Factories.StatisticsContext.TournamentStatistics;
    using Application.Features.TournamentContext.Team;
    using Application.Features.TournamentContext.Tournament;

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
            private readonly ITournamentRepository tournamentRepository;
            private readonly ITournamentStatisticsFactory tournamentStatisticsFactory;

            public CreateTournamentStatisticsCommandHandler(
                ITournamentStatisticsRepository tournamentStatisticsRepository,
                ITournamentRepository tournamentRepository,
                ITournamentStatisticsFactory tournamentStatisticsFactory)
            {
                this.tournamentStatisticsRepository = tournamentStatisticsRepository;
                this.tournamentRepository = tournamentRepository;
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

                var tournament = await this.tournamentRepository.GetTournamentById(request.TournamentId);
                tournament.AddTournamentStatistics(tournamentStatistics.Id);

                return new CreateTournamentStatisticsOutputModel(tournamentStatistics.Id);
            }
        }
    }
}

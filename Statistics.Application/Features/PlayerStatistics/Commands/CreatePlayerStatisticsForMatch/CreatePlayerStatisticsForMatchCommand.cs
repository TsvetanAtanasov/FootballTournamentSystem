namespace FootballTournamentSystem.Statistics.Application.Features.PlayerStatistics.CreatePlayerStatisticsForMatch
{
    using FootballTournamentSystem.Statistics.Application.Features.PlayerStatistics.Common;
    using FootballTournamentSystem.Statistics.Domain.Factories.PlayerStatistics;
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;

    public class CreatePlayerStatisticsForMatchCommand : IRequest<CreatePlayerStatisticsOutputModel>
    {
        public CreatePlayerStatisticsForMatchCommand(int matchId, int goalsScored, int minutesPlayed, int assists)
        {
            this.MatchId = matchId;
            this.GoalsScored = goalsScored;
            this.MinutesPlayed = minutesPlayed;
            this.Assists = assists;
        }

        public int MatchId { get; }

        public int GoalsScored { get; }

        public int MinutesPlayed { get; }

        public int Assists { get; }

        public class CreatePlayerStatisticsCommandHandler : IRequestHandler<CreatePlayerStatisticsForMatchCommand, CreatePlayerStatisticsOutputModel>
        {
            private readonly IPlayerStatisticsRepository playerStatisticsRepository;
            private readonly IPlayerStatisticsFactory playerStatisticsFactory;

            public CreatePlayerStatisticsCommandHandler(
                IPlayerStatisticsRepository playerStatisticsRepository,
                IPlayerStatisticsFactory playerStatisticsFactory)
            {
                this.playerStatisticsRepository = playerStatisticsRepository;
                this.playerStatisticsFactory = playerStatisticsFactory;
            }

            public async Task<CreatePlayerStatisticsOutputModel> Handle(CreatePlayerStatisticsForMatchCommand request, CancellationToken cancellationToken)
            {
                var playerStatistics = this.playerStatisticsFactory
                    .WithGoalsScored(request.GoalsScored)
                    .WithMinutesPlayed(request.MinutesPlayed)
                    .WithAssists(request.Assists)
                    .Build();

                await this.playerStatisticsRepository.Save(playerStatistics, cancellationToken);
                // TODO: add event
                //var match = await this.matchRepository.GetMatchById(request.MatchId);
                //match.AddPlayerStatistics(playerStatistics.Id);

                // save match also?

                return new CreatePlayerStatisticsOutputModel(playerStatistics.Id);
            }
        }
    }
}

namespace FootballTournamentSystem.Application.Features.StatisticsContext.PlayerStatistics.CreatePlayerStatisticsForPlayer
{
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;
    using Application.Features.TournamentContext.Match;
    using Application.Features.StatisticsContext.PlayerStatistics.Common;
    using Application.Features.PersonContext.Player;
    using Domain.Factories.StatisticsContext.PlayerStatistics;

    public class CreatePlayerStatisticsForPlayerCommand : IRequest<CreatePlayerStatisticsOutputModel>
    {
        public CreatePlayerStatisticsForPlayerCommand(int playerId, int goalsScored, int minutesPlayed, int assists)
        {
            this.PlayerId = playerId;
            this.GoalsScored = goalsScored;
            this.MinutesPlayed = minutesPlayed;
            this.Assists = assists;
        }

        public int PlayerId { get; }

        public int GoalsScored { get; }

        public int MinutesPlayed { get; }

        public int Assists { get; }

        public class CreatePlayerStatisticsForPlayerCommandHandler : IRequestHandler<CreatePlayerStatisticsForPlayerCommand, CreatePlayerStatisticsOutputModel>
        {
            private readonly IPlayerStatisticsRepository playerStatisticsRepository;
            private readonly IPlayerRepository playerRepository;
            private readonly IPlayerStatisticsFactory playerStatisticsFactory;

            public CreatePlayerStatisticsForPlayerCommandHandler(
                IPlayerStatisticsRepository playerStatisticsRepository,
                IPlayerRepository playerRepository,
                IPlayerStatisticsFactory playerStatisticsFactory)
            {
                this.playerStatisticsRepository = playerStatisticsRepository;
                this.playerRepository = playerRepository;
                this.playerStatisticsFactory = playerStatisticsFactory;
            }

            public async Task<CreatePlayerStatisticsOutputModel> Handle(CreatePlayerStatisticsForPlayerCommand request, CancellationToken cancellationToken)
            {
                var playerStatistics = this.playerStatisticsFactory
                    .WithGoalsScored(request.GoalsScored)
                    .WithMinutesPlayed(request.MinutesPlayed)
                    .WithAssists(request.Assists)
                    .Build();

                await this.playerStatisticsRepository.Save(playerStatistics, cancellationToken);

                var player = await this.playerRepository.GetPlayerById(request.PlayerId);
                player.AddPlayerStatistics(playerStatistics.Id);

                // save player also?

                return new CreatePlayerStatisticsOutputModel(playerStatistics.Id);
            }
        }
    }
}

namespace FootballTournamentSystem.Statistics.Application.Features.PlayerStatistics.CreatePlayerStatisticsForPlayer
{
    using System.Threading;
    using System.Threading.Tasks;
    using System;
    using MediatR;
    using FootballTournamentSystem.Statistics.Application.Features.PlayerStatistics.Common;
    using FootballTournamentSystem.Statistics.Domain.Factories.PlayerStatistics;

    public class CreatePlayerStatisticsForPlayerCommand : IRequest<CreatePlayerStatisticsOutputModel>
    {
        public CreatePlayerStatisticsForPlayerCommand(Guid playerId, int goalsScored, int minutesPlayed, int assists)
        {
            this.PlayerId = playerId;
            this.GoalsScored = goalsScored;
            this.MinutesPlayed = minutesPlayed;
            this.Assists = assists;
        }

        public Guid PlayerId { get; }

        public int GoalsScored { get; }

        public int MinutesPlayed { get; }

        public int Assists { get; }

        public class CreatePlayerStatisticsForPlayerCommandHandler : IRequestHandler<CreatePlayerStatisticsForPlayerCommand, CreatePlayerStatisticsOutputModel>
        {
            private readonly IPlayerStatisticsRepository playerStatisticsRepository;
            private readonly IPlayerStatisticsFactory playerStatisticsFactory;

            public CreatePlayerStatisticsForPlayerCommandHandler(
                IPlayerStatisticsRepository playerStatisticsRepository,
                IPlayerStatisticsFactory playerStatisticsFactory)
            {
                this.playerStatisticsRepository = playerStatisticsRepository;
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

                //TODO: add event
                //var player = await this.playerRepository.GetPlayerById(request.PlayerId);
                //player.AddPlayerStatistics(playerStatistics.Id);

                //// save player also?

                return new CreatePlayerStatisticsOutputModel(playerStatistics.Id);
            }
        }
    }
}

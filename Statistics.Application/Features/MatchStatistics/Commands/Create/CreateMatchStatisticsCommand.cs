namespace FootballTournamentSystem.Statistics.Application.Features.MatchStatistics.Commands.Create
{
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using FootballTournamentSystem.Statistics.Domain.Factories.MatchStatistics;

    public class CreateMatchStatisticsCommand : IRequest<CreateMatchStatisticsOutputModel>
    {
        public CreateMatchStatisticsCommand(int matchId, int homeTeamGoals, int awayTeamGoals, List<int> goalScorerIds, List<int> assistMakerIds)
        {
            this.MatchId = matchId;
            this.HomeTeamGoals = homeTeamGoals;
            this.AwayTeamGoals = awayTeamGoals;
            this.GoalScorerIds = goalScorerIds;
            this.AssistMakerIds = assistMakerIds;
        }

        public int MatchId { get; }

        public int HomeTeamGoals { get; }

        public int AwayTeamGoals { get; }

        public List<int> GoalScorerIds { get; }

        public List<int> AssistMakerIds { get; }

        public class CreateMatchStatisticsCommandHandler : IRequestHandler<CreateMatchStatisticsCommand, CreateMatchStatisticsOutputModel>
        {
            private readonly IMatchStatisticsRepository matchStatisticsRepository;
            private readonly IMatchStatisticsFactory matchStatisticsFactory;

            public CreateMatchStatisticsCommandHandler(
                IMatchStatisticsRepository matchStatisticsRepository,
                IMatchStatisticsFactory matchStatisticsFactory)
            {
                this.matchStatisticsRepository = matchStatisticsRepository;
                this.matchStatisticsFactory = matchStatisticsFactory;
            }

            public async Task<CreateMatchStatisticsOutputModel> Handle(CreateMatchStatisticsCommand request, CancellationToken cancellationToken)
            {
                var matchStatistics = this.matchStatisticsFactory
                    .WithHomeTeamGoals(request.HomeTeamGoals)
                    .WithAwayTeamGoals(request.AwayTeamGoals)
                    .Build();

                matchStatistics.AddGoalScorers(request.GoalScorerIds);
                matchStatistics.AddAssistMakers(request.AssistMakerIds);

                await this.matchStatisticsRepository.Save(matchStatistics, cancellationToken);

                // TODO: add event
                // match.AddMatchStatistics(matchStatistics.Id);

                // save match also?

                return new CreateMatchStatisticsOutputModel(matchStatistics.Id);
            }
        }
    }
}

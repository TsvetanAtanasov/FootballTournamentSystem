namespace FootballTournamentSystem.Application.Features.Statistics.MatchStatistics.Create
{
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using Domain.Factories.Statistics.TournamentStatistics;
    using Domain.Factories.Statistics.MatchStatistics;
    using Application.Features.Tournament.Tournament;
    using Application.Features.Tournament.Match;

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
            private readonly IMatchRepository matchRepository;
            private readonly IMatchStatisticsFactory matchStatisticsFactory;

            public CreateMatchStatisticsCommandHandler(
                IMatchStatisticsRepository matchStatisticsRepository,
                IMatchRepository matchRepository,
                IMatchStatisticsFactory matchStatisticsFactory)
            {
                this.matchStatisticsRepository = matchStatisticsRepository;
                this.matchRepository = matchRepository;
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

                var match = await this.matchRepository.GetMatchById(request.MatchId);
                match.AddMatchStatistics(matchStatistics.Id);

                // save match also?

                return new CreateMatchStatisticsOutputModel(matchStatistics.Id);
            }
        }
    }
}

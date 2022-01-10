namespace Tournament.Application.Features.Team.Messages
{
    using System.Threading;
    using System.Threading.Tasks;
    using MassTransit;
    using Core.Application.Messages;
    using FootballTournamentSystem.Tournament.Application.Features.Team;


    public class CoachCreatedConsumer : IConsumer<CoachCreatedMessage>
    {
        private readonly ITeamRepository teamRepository;
        private readonly CancellationToken cancellationToken;

        public CoachCreatedConsumer(ITeamRepository teamRepository, CancellationToken cancellationToken)
        {
            this.teamRepository = teamRepository;
            this.cancellationToken = cancellationToken;
        }

        public Task Consume(ConsumeContext<CoachCreatedMessage> context)
            => this.teamRepository.AddCoachToTeam(context.Message.TeamId, context.Message.CoachId, this.cancellationToken);
    }
}

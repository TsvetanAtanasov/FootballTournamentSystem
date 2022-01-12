namespace FootballTournamentSystem.Tournament.Application.Features.Team.Messages
{
    using System.Threading;
    using System.Threading.Tasks;
    using MassTransit;
    using Core.Application.Messages;
    using FootballTournamentSystem.Tournament.Application.Features.Team;


    public class PresidentCreatedConsumer : IConsumer<PresidentCreatedMessage>
    {
        private readonly ITeamRepository teamRepository;
        private readonly CancellationToken cancellationToken;

        public PresidentCreatedConsumer(ITeamRepository teamRepository, CancellationToken cancellationToken)
        {
            this.teamRepository = teamRepository;
            this.cancellationToken = cancellationToken;
        }

        public Task Consume(ConsumeContext<PresidentCreatedMessage> context)
            => this.teamRepository.AddPresidentToTeam(context.Message.TeamId, context.Message.PresidentId, this.cancellationToken);
    }
}

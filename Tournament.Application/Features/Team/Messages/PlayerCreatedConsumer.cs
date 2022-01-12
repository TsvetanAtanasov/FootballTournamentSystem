namespace FootballTournamentSystem.Tournament.Application.Features.Team.Messages
{
    using System.Threading;
    using System.Threading.Tasks;
    using MassTransit;
    using Core.Application.Messages;
    using FootballTournamentSystem.Tournament.Application.Features.Team;


    public class PlayerCreatedConsumer : IConsumer<PlayerCreatedMessage>
    {
        private readonly ITeamRepository teamRepository;
        private readonly CancellationToken cancellationToken;

        public PlayerCreatedConsumer(ITeamRepository teamRepository, CancellationToken cancellationToken)
        {
            this.teamRepository = teamRepository;
            this.cancellationToken = cancellationToken;
        }

        public Task Consume(ConsumeContext<PlayerCreatedMessage> context)
            => this.teamRepository.AddPlayerToTeam(context.Message.TeamId, context.Message.PlayerId, this.cancellationToken);
    }
}

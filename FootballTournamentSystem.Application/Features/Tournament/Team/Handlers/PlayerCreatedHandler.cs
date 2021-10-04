namespace FootballTournamentSystem.Application.Features.Tournament.Team.Handlers
{
    using System.Threading.Tasks;
    using System.Threading;
    using global::Common.Domain.Events;
    using global::Common.Application;

    public class PlayerCreatedHandler : IEventHandler<PlayerCreatedEvent>
    {
        private readonly ITeamRepository teamRepository;
        private readonly CancellationToken cancellationToken;

        public PlayerCreatedHandler(ITeamRepository teamRepository, CancellationToken cancellationToken)
        {
            this.teamRepository = teamRepository;
            this.cancellationToken = cancellationToken;
        }

        public Task Handle(PlayerCreatedEvent domainEvent)
            => this.teamRepository.AddPlayerToTeam(domainEvent.TeamId, domainEvent.PlayerId, this.cancellationToken);
    }
}

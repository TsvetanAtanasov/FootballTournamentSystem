namespace FootballTournamentSystem.Application.Features.Tournament.Team.Handlers
{
    using Common.Application;
    using Common.Domain.Events;
    using TournamentContext.Team;
    using System.Threading.Tasks;
    using System.Threading;

    public class PresidentCreatedHandler : IEventHandler<PresidentCreatedEvent>
    {
        private readonly ITeamRepository teamRepository;
        private readonly CancellationToken cancellationToken;

        public PresidentCreatedHandler(ITeamRepository teamRepository, CancellationToken cancellationToken)
        {
            this.teamRepository = teamRepository;
            this.cancellationToken = cancellationToken;
        }

        public Task Handle(PresidentCreatedEvent domainEvent)
            => this.teamRepository.AddPresidentToTeam(domainEvent.TeamId, domainEvent.PresidentId, this.cancellationToken);
    }
}

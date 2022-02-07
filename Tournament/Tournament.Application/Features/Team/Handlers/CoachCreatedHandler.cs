namespace FootballTournamentSystem.Tournament.Application.Features.Team.Handlers
{
    using System.Threading.Tasks;
    using System.Threading;
    using Core.Application;
    using Core.Domain.Events;

    public class CoachCreatedHandler : IEventHandler<CoachCreatedEvent>
    {
        private readonly ITeamRepository teamRepository;
        private readonly CancellationToken cancellationToken;

        public CoachCreatedHandler(ITeamRepository teamRepository, CancellationToken cancellationToken)
        {
            this.teamRepository = teamRepository;
            this.cancellationToken = cancellationToken;
        }

        public Task Handle(CoachCreatedEvent domainEvent)
            => this.teamRepository.AddCoachToTeam(domainEvent.TeamId, domainEvent.CoachId, this.cancellationToken);
    }
}

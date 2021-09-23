namespace FootballTournamentSystem.Application.Features.Tournament.Team.Handlers
{
    using Common.Application;
    using Common.Domain.Events;
    using TournamentContext.Team;
    using System.Threading.Tasks;

    public class PresidentCreatedHandler : IEventHandler<PresidentCreatedEvent>
    {
        private readonly ITeamRepository teamRepository;

        public PresidentCreatedHandler(ITeamRepository teamRepository) 
            => this.teamRepository = teamRepository;

        public Task Handle(PresidentCreatedEvent domainEvent)
            => this.teamRepository.AddPresidentToTeam(domainEvent.TeamId, domainEvent.PresidentId);
    }
}

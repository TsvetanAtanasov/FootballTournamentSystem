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

        public PresidentCreatedConsumer(ITeamRepository teamRepository)
        {
            this.teamRepository = teamRepository;
        }

        public Task Consume(ConsumeContext<PresidentCreatedMessage> context)
            => this.teamRepository.AddPresidentToTeam(context.Message.TeamId, context.Message.PresidentId);
    }
}

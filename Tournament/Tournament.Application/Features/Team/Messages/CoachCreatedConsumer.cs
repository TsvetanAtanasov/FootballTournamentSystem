namespace FootballTournamentSystem.Tournament.Application.Features.Team.Messages
{
    using System.Threading;
    using System.Threading.Tasks;
    using MassTransit;
    using Core.Application.Messages;
    using FootballTournamentSystem.Tournament.Application.Features.Team;


    public class CoachCreatedConsumer : IConsumer<CoachCreatedMessage>
    {
        private readonly ITeamRepository teamRepository;

        public CoachCreatedConsumer(ITeamRepository teamRepository)
        {
            this.teamRepository = teamRepository;
        }

        public Task Consume(ConsumeContext<CoachCreatedMessage> context)
            => this.teamRepository.AddCoachToTeam(context.Message.TeamId, context.Message.CoachGuid);
    }
}

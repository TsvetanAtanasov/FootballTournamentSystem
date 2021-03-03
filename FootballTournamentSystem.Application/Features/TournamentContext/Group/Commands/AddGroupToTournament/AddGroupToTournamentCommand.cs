namespace FootballTournamentSystem.Application.Features.TournamentContext.Tournament.Commands.Groups
{
    using Domain.Factories.TournamentContext.Group;
    using Features.TournamentContext.Group;
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;

    public class AddGroupToTournamentCommand : IRequest<AddGroupToTournamentOutputModel>
    {
        public AddGroupToTournamentCommand(int tournamentId, string name)
        {
            this.TournamentId = tournamentId;
            this.Name = name;
        }

        public int TournamentId { get; }

        public string Name { get; }

        public class AddGroupToTournamentCommandHandler : IRequestHandler<AddGroupToTournamentCommand, AddGroupToTournamentOutputModel>
        {
            private readonly ITournamentRepository tournamentRepository;
            private readonly IGroupFactory groupFactory;
            private readonly IGroupRepository groupRepository;

            public AddGroupToTournamentCommandHandler(ITournamentRepository tournamentRepository, IGroupFactory groupFactory, IGroupRepository groupRepository)
            {
                this.tournamentRepository = tournamentRepository;
                this.groupFactory = groupFactory;
                this.groupRepository = groupRepository;
            }

            public async Task<AddGroupToTournamentOutputModel> Handle(AddGroupToTournamentCommand request, CancellationToken cancellationToken)
            {
                var tournament = await this.tournamentRepository.GetTournamentById(request.TournamentId);
                var group = this.groupFactory
                    .WithName(request.Name)
                    .Build();

                tournament.AddGroup(group);

                await this.groupRepository.Save(group, cancellationToken);

                return new AddGroupToTournamentOutputModel(tournament.Id);
            }
        }
    }
}

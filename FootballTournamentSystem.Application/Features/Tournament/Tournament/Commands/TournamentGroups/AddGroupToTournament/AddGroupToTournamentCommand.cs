namespace FootballTournamentSystem.Application.Features.Tournament.Tournament.Commands.TournamentGroups.AddGroupToTournament
{
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;

    public class AddGroupToTournamentCommand : IRequest<AddGroupToTournamentOutputModel>
    {
        public AddGroupToTournamentCommand(int tournamentId, string groupName)
        {
            this.TournamentId = tournamentId;
            this.GroupName = groupName;
        }

        public int TournamentId { get; }

        public string GroupName { get; }

        public class AddGroupToTournamentCommandHandler : IRequestHandler<AddGroupToTournamentCommand, AddGroupToTournamentOutputModel>
        {
            private readonly ITournamentRepository tournamentRepository;

            public AddGroupToTournamentCommandHandler(ITournamentRepository tournamentRepository)
            {
                this.tournamentRepository = tournamentRepository;
            }

            public async Task<AddGroupToTournamentOutputModel> Handle(AddGroupToTournamentCommand request, CancellationToken cancellationToken)
            {
                var tournament = await this.tournamentRepository.GetTournamentById(request.TournamentId);

                var group = tournament.AddGroup(request.GroupName);

                await this.tournamentRepository.Save(tournament, cancellationToken);

                return new AddGroupToTournamentOutputModel(group.Id);
            }
        }
    }
}

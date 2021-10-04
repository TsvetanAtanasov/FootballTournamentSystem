namespace FootballTournamentSystem.Application.Features.Tournament.Tournament.Commands.Create
{
    using Domain.Factories.Tournament.Tournament;
    using Domain.Models.Tournament.Tournament;
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;

    public class CreateTournamentCommand : IRequest<CreateTournamentOutputModel>
    {
        public CreateTournamentCommand(int numberOfTeams, string imageUrl)
        {
            this.NumberOfTeams = numberOfTeams;
            this.ImageUrl = imageUrl;
        }

        public int NumberOfTeams { get; }

        public string ImageUrl { get; }

        public class CreateTournamentCommandHandler : IRequestHandler<CreateTournamentCommand, CreateTournamentOutputModel>
        {
            private readonly ITournamentRepository tournamentRepository;
            private readonly ITournamentFactory tournamentFactory;

            public CreateTournamentCommandHandler(ITournamentRepository tournamentRepository, ITournamentFactory tournamentFactory)
            {
                this.tournamentRepository = tournamentRepository;
                this.tournamentFactory = tournamentFactory;
            }

            public async Task<CreateTournamentOutputModel> Handle(CreateTournamentCommand request, CancellationToken cancellationToken)
            {
                var tournament = this.tournamentFactory
                    .WithNumberOfTeams(request.NumberOfTeams)
                    .WithImageUrl(request.ImageUrl)
                    .Build();

                await this.tournamentRepository.Save(tournament, cancellationToken);

                return new CreateTournamentOutputModel(tournament.Id);
            }
        }
    }
}

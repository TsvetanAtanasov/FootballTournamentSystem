namespace FootballTournamentSystem.Application.Features.TournamentContext.Match.Commands.Create
{
    using Domain.Factories.TournamentContext.Match;
    using Domain.Models.TournamentContext.Match;
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;

    public class CreateMatchCommand : IRequest<CreateMatchOutputModel>
    {
        public CreateMatchCommand(int homeTeamId, int awayTeamId, int refereeId)
        {
            this.HomeTeamId = homeTeamId;
            this.AwayTeamId = awayTeamId;
            this.RefereeId = refereeId;
        }

        public int HomeTeamId { get; }

        public int AwayTeamId { get; }

        public int RefereeId { get; }

        public class CreateMatchCommandHandler : IRequestHandler<CreateMatchCommand, CreateMatchOutputModel>
        {
            private readonly IMatchRepository matchRepository;
            private readonly IMatchFactory matchFactory;

            public CreateMatchCommandHandler(IMatchRepository matchRepository, IMatchFactory matchFactory)
            {
                this.matchRepository = matchRepository;
                this.matchFactory = matchFactory;
            }

            public async Task<CreateMatchOutputModel> Handle(CreateMatchCommand request, CancellationToken cancellationToken)
            {
                var match = this.matchFactory
                    .WithTournamentType(request.TournamentType)
                    .WithNumberOfTeams(request.NumberOfTeams)
                    .WithImageUrl(request.ImageUrl)
                    .Build();

                await this.tournamentRepository.Save(tournament, cancellationToken);

                return new CreateMatchOutputModel(tournament.Id);
            }
        }
    }
}

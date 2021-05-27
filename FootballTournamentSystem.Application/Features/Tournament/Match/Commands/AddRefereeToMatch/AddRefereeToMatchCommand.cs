namespace FootballTournamentSystem.Application.Features.TournamentContext.Match.Commands.AddRefereeToMatch
{
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;

    public class AddRefereeToMatchCommand : IRequest<AddRefereeToMatchOutputModel>
    {
        public AddRefereeToMatchCommand(int matchId, int refereeId)
        {
            this.MatchId = matchId;
            this.RefereeId = refereeId;
        }

        public int MatchId { get; }

        public int RefereeId { get; }

        public class AddRefereeToMatchCommandHandler : IRequestHandler<AddRefereeToMatchCommand, AddRefereeToMatchOutputModel>
        {
            private readonly IMatchRepository matchRepository;

            public AddRefereeToMatchCommandHandler(IMatchRepository matchRepository)
            {
                this.matchRepository = matchRepository;
            }

            public async Task<AddRefereeToMatchOutputModel> Handle(AddRefereeToMatchCommand request, CancellationToken cancellationToken)
            {
                var match = await this.matchRepository.GetMatchById(request.MatchId);

                match.AddReferee(request.RefereeId);

                await this.matchRepository.Save(match, cancellationToken);

                return new AddRefereeToMatchOutputModel(match.Id);
            }
        }
    }
}

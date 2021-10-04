namespace FootballTournamentSystem.Application.Features.Tournament.Tournament.Queries.TournamentGroups.GroupMatches
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using FootballTournamentSystem.Application.Features.Tournament.Tournament;
    using global::Common.Application;
    using MediatR;

    public class GetGroupMatchesQuery : EntityCommand<int>, IRequest<IEnumerable<GetGroupMatchOutputModel>>
    {
        public class GetGroupMatchesQueryHandler : IRequestHandler<GetGroupMatchesQuery, IEnumerable<GetGroupMatchOutputModel>>
        {
            private readonly ITournamentRepository tournamentRepository;

            public GetGroupMatchesQueryHandler(ITournamentRepository tournamentRepository)
            {
                this.tournamentRepository = tournamentRepository;
            }

            public async Task<IEnumerable<GetGroupMatchOutputModel>> Handle(
                GetGroupMatchesQuery request,
                CancellationToken cancellationToken)
            {
                var groupMatches = await this.tournamentRepository.GetGroupMatches(
                    request.Id,
                    cancellationToken);

                return groupMatches;
            }
        }
    }
}

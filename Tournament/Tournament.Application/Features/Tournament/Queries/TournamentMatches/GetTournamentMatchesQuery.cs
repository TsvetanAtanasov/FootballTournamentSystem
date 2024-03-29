﻿namespace FootballTournamentSystem.Tournament.Application.Features.Tournament.Queries.TournamentMatches
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using FootballTournamentSystem.Application.Features.Tournament.Tournament;
    using Core.Application;
    using MediatR;

    public class GetTournamentMatchesQuery : EntityCommand<int>, IRequest<IEnumerable<GetTournamentMatchOutputModel>>
    {
        public class GetTournamentMatchesQueryHandler : IRequestHandler<GetTournamentMatchesQuery, IEnumerable<GetTournamentMatchOutputModel>>
        {
            private readonly ITournamentRepository tournamentRepository;

            public GetTournamentMatchesQueryHandler(ITournamentRepository tournamentRepository)
            {
                this.tournamentRepository = tournamentRepository;
            }

            public async Task<IEnumerable<GetTournamentMatchOutputModel>> Handle(
                GetTournamentMatchesQuery request,
                CancellationToken cancellationToken)
            {
                var tournamentMatches = await this.tournamentRepository.GetTournamentMatches(
                    request.Id,
                    cancellationToken);

                return tournamentMatches;
            }
        }
    }
}

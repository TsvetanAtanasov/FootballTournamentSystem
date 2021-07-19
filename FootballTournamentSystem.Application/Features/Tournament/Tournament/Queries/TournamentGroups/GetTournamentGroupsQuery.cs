﻿namespace FootballTournamentSystem.Application.Features.TournamentContext.Tournament.Queries.TournamentGroups
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using FootballTournamentSystem.Application.Features.TournamentContext.Tournament;
    using global::Common.Application;
    using MediatR;

    public class GetTournamentGroupsQuery : EntityCommand<int>, IRequest<IEnumerable<GetTournamentGroupOutputModel>>
    {
        public class GetTournamentGroupsQueryHandler : IRequestHandler<GetTournamentGroupsQuery, IEnumerable<GetTournamentGroupOutputModel>>
        {
            private readonly ITournamentRepository tournamentRepository;

            public GetTournamentGroupsQueryHandler(ITournamentRepository tournamentRepository)
            {
                this.tournamentRepository = tournamentRepository;
            }

            public async Task<IEnumerable<GetTournamentGroupOutputModel>> Handle(
                GetTournamentGroupsQuery request,
                CancellationToken cancellationToken)
            {
                var tournamentGroups = await this.tournamentRepository.GetTournamentGroups(
                    request.Id,
                    cancellationToken);

                return tournamentGroups;
            }
        }
    }
}

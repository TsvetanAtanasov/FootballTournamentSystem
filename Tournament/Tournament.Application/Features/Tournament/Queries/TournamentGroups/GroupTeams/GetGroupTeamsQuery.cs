﻿namespace FootballTournamentSystem.Tournament.Application.Features.Tournament.Queries.TournamentGroups.GroupTeams
{
    using MediatR;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Core.Application;
    using FootballTournamentSystem.Tournament.Application.Features.Team.Common;
    using FootballTournamentSystem.Application.Features.Tournament.Tournament;

    public class GetGroupTeamsQuery : EntityCommand<int>, IRequest<IEnumerable<TeamOutputModel>>
    {
        public class GetGroupTeamsQueryHandler : IRequestHandler<GetGroupTeamsQuery, IEnumerable<TeamOutputModel>>
        {
            private readonly ITournamentRepository tournamentRepository;

            public GetGroupTeamsQueryHandler(ITournamentRepository tournamentRepository)
            {
                this.tournamentRepository = tournamentRepository;
            }

            public async Task<IEnumerable<TeamOutputModel>> Handle(GetGroupTeamsQuery request, CancellationToken cancellationToken)
            {
                return await this.tournamentRepository.GetGroupTeams(
                    request.Id,
                    cancellationToken);
            }
        }
    }
}

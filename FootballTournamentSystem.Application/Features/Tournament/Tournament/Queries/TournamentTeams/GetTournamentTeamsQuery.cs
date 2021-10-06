namespace FootballTournamentSystem.Application.Features.Tournament.Tournament.Queries.TournamentTeams
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using Features.Tournament.Team.Common;
    using Features.Tournament.Tournament;
    using Core.Application;
    using MediatR;

    public class GetTournamentTeamsQuery : EntityCommand<int>, IRequest<IEnumerable<TeamOutputModel>>
    {
        public class GetTournamentTeamsQueryHandler : IRequestHandler<GetTournamentTeamsQuery, IEnumerable<TeamOutputModel>>
        {
            private readonly ITournamentRepository tournamentRepository;

            public GetTournamentTeamsQueryHandler(ITournamentRepository tournamentRepository)
            {
                this.tournamentRepository = tournamentRepository;
            }

            public async Task<IEnumerable<TeamOutputModel>> Handle(
                GetTournamentTeamsQuery request,
                CancellationToken cancellationToken)
            {
                var tournamentGroups = await this.tournamentRepository.GetTournamentGroups(
                    request.Id,
                    cancellationToken);

                var groupIds = tournamentGroups.Select(tg => tg.Id).ToList();

                var tournamentTeams = await this.tournamentRepository.GetTournamentTeams(groupIds);

                return tournamentTeams;
            }
        }
    }
}

namespace FootballTournamentSystem.Tournament.Application.Features.Tournament.Queries.TournamentTeams
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using MediatR;
    using Core.Application;
    using FootballTournamentSystem.Tournament.Application.Features.Team.Common;
    using FootballTournamentSystem.Application.Features.Tournament.Tournament;

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

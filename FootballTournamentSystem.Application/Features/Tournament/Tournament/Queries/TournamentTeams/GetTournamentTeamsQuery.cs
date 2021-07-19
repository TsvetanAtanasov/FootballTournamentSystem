namespace FootballTournamentSystem.Application.Features.TournamentContext.Tournament.Queries.TournamentTeams
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using Features.TournamentContext.Team.Common;
    using Features.TournamentContext.Tournament;
    using global::Common.Application;
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

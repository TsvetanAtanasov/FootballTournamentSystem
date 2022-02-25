namespace Tournament.Application.Features.Team.Queries
{
    using System.Threading;
    using System.Threading.Tasks;
    using FootballTournamentSystem.Tournament.Application.Features.Team.Common;
    using FootballTournamentSystem.Tournament.Application.Features.Team;
    using Core.Application;
    using MediatR;

    public class GetTeamByIdQuery : EntityCommand<int>, IRequest<TeamOutputModel>
    {
        public class GetTeamByIdQueryHandler : IRequestHandler<GetTeamByIdQuery, TeamOutputModel>
        {
            private readonly ITeamRepository teamRepository;

            public GetTeamByIdQueryHandler(ITeamRepository teamRepository)
            {
                this.teamRepository = teamRepository;
            }

            public async Task<TeamOutputModel> Handle(
                GetTeamByIdQuery request,
                CancellationToken cancellationToken)
            {
                var team = await this.teamRepository.GetTeamById(
                    request.Id,
                    cancellationToken);

                return new TeamOutputModel(team.Id, team.Name, team.LogoUrl, team.YearFounded, null!, null!, null!, null!, null!, null!, team.Country, team.Stadium, team.GroupPoints);
            }
        }
    }
}

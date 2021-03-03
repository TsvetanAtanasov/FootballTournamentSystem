namespace FootballTournamentSystem.Application.Features.TournamentContext.Group.Queries.GroupTeams
{
    using MediatR;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Features.TournamentContext.Team.Common;

    public class GetGroupTeamsQuery : EntityCommand<int>, IRequest<IEnumerable<TeamOutputModel>>
    {
        public class GetGroupTeamsQueryHandler : IRequestHandler<GetGroupTeamsQuery, IEnumerable<TeamOutputModel>>
        {
            private readonly IGroupRepository groupRepository;

            public GetGroupTeamsQueryHandler(IGroupRepository groupRepository)
            {
                this.groupRepository = groupRepository;
            }

            public async Task<IEnumerable<TeamOutputModel>> Handle(GetGroupTeamsQuery request, CancellationToken cancellationToken)
            {
                return await this.groupRepository.GetGroupTeams(
                    request.Id,
                    cancellationToken);
            }
        }
    }
}

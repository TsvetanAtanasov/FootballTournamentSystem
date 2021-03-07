namespace FootballTournamentSystem.Application.Features.TournamentContext.Group.Queries.GroupMatches
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using FootballTournamentSystem.Application.Features.TournamentContext.Tournament;
    using MediatR;

    public class GetGroupMatchesQuery : EntityCommand<int>, IRequest<IEnumerable<GetGroupMatchOutputModel>>
    {
        public class GetGroupMatchesQueryHandler : IRequestHandler<GetGroupMatchesQuery, IEnumerable<GetGroupMatchOutputModel>>
        {
            private readonly IGroupRepository groupRepository;

            public GetGroupMatchesQueryHandler(IGroupRepository groupRepository)
            {
                this.groupRepository = groupRepository;
            }

            public async Task<IEnumerable<GetGroupMatchOutputModel>> Handle(
                GetGroupMatchesQuery request,
                CancellationToken cancellationToken)
            {
                var groupMatches = await this.groupRepository.GetGroupMatches(
                    request.Id,
                    cancellationToken);

                return groupMatches;
            }
        }
    }
}

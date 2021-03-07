namespace FootballTournamentSystem.Application.Features.TournamentContext.Group
{
    using Application.Contracts;
    using Domain.Models.TournamentContext.Group;
    using Features.TournamentContext.Team.Common;
    using Features.TournamentContext.Group.Queries.GroupMatches;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public interface IGroupRepository : IRepository<Group>
    {
        Task<IEnumerable<TeamOutputModel>> GetGroupTeams(int groupId, CancellationToken cancellationToken = default);

        Task<IEnumerable<GetGroupMatchOutputModel>> GetGroupMatches(int groupId, CancellationToken cancellationToken = default);
    }
}

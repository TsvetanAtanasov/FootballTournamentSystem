namespace FootballTournamentSystem.Application.Features.TournamentContext.Group
{
    using Application.Contracts;
    using Domain.Models.TournamentContext.Group;
    using Features.TournamentContext.Team.Common;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public interface IGroupRepository : IRepository<Group>
    {
        Task<IEnumerable<TeamOutputModel>> GetGroupTeams(int groupId, CancellationToken cancellationToken = default);
    }
}

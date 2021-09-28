namespace FootballTournamentSystem.Application.Features.TournamentContext.Team
{
    using Application.Contracts;
    using Domain.Models.TournamentContext.Team;
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public interface ITeamRepository : IRepository<Team>
    {
        Task<Team> GetTeamById(int teamId, CancellationToken cancellationToken = default);

        Task AddPresidentToTeam(int teamId, Guid presidentId, CancellationToken cancellationToken = default);
    }
}

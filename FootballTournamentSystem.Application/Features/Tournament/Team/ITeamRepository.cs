namespace FootballTournamentSystem.Application.Features.Tournament.Team
{
    using Application.Contracts;
    using Domain.Models.Tournament.Team;
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public interface ITeamRepository : IRepository<Team>
    {
        Task<Team> GetTeamById(int teamId, CancellationToken cancellationToken = default);

        Task AddPresidentToTeam(int teamId, Guid presidentId, CancellationToken cancellationToken = default);

        Task AddPlayerToTeam(int teamId, Guid playerId, CancellationToken cancellationToken = default);

        Task AddCoachToTeam(int teamId, Guid coachId, CancellationToken cancellationToken = default);
    }
}

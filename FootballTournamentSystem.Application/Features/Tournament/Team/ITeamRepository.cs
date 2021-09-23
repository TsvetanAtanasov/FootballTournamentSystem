namespace FootballTournamentSystem.Application.Features.TournamentContext.Team
{
    using Application.Contracts;
    using Domain.Models.TournamentContext.Team;
    using System.Threading;
    using System.Threading.Tasks;

    public interface ITeamRepository : IRepository<Team>
    {
        Task<Team> GetTeamById(int teamId, CancellationToken cancellationToken = default);

        Task AddPresidentToTeam(int teamId, int presidentId);
    }
}

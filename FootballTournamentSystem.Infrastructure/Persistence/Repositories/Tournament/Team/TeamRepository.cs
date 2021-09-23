namespace FootballTournamentSystem.Infrastructure.Persistence.Repositories.TournamentContext.Team
{
    using Common.Infrastructure.Persistence;
    using Domain.Models.TournamentContext.Team;
    using FootballTournamentSystem.Application.Features.TournamentContext.Team;
    using Microsoft.EntityFrameworkCore;
    using System.Threading;
    using System.Threading.Tasks;

    internal class TeamRepository : FootballTournamentDataRepository<Team>, ITeamRepository
    {
        public TeamRepository(FootballTournamentDbContext db)
            : base(db)
        {

        }

        public Task AddPresidentToTeam(int teamId, int presidentId)
        {
            // TODO
            throw new System.NotImplementedException();
        }

        public async Task<Team> GetTeamById(int teamId, CancellationToken cancellationToken = default)
        {
            return await this.Data.Teams.FirstOrDefaultAsync(t => t.Id == teamId, cancellationToken);
        }
    }
}

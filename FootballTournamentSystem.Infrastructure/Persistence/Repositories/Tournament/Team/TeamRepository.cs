namespace FootballTournamentSystem.Infrastructure.Persistence.Repositories.TournamentContext.Team
{
    using Common.Infrastructure.Persistence;
    using Domain.Models.TournamentContext.Team;
    using FootballTournamentSystem.Application.Features.TournamentContext.Team;
    using Microsoft.EntityFrameworkCore;
    using System.Threading;
    using System.Threading.Tasks;

    internal class TeamRepository : DataRepository<FootballTournamentDbContext, Team>, ITeamRepository
    {
        public TeamRepository(FootballTournamentDbContext db)
            : base(db)
        {

        }

        public async Task<Team> GetTeamById(int teamId, CancellationToken cancellationToken = default)
        {
            return await this.Data.Teams.FirstOrDefaultAsync(t => t.Id == teamId, cancellationToken);
        }
    }
}

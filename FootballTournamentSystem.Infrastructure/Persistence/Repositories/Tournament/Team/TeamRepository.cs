namespace FootballTournamentSystem.Infrastructure.Persistence.Repositories.TournamentContext.Team
{
    using Common.Infrastructure.Persistence;
    using Domain.Models.TournamentContext.Team;
    using FootballTournamentSystem.Application.Features.TournamentContext.Team;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    internal class TeamRepository : FootballTournamentDataRepository<Team>, ITeamRepository
    {
        public TeamRepository(FootballTournamentDbContext db)
            : base(db)
        {

        }

        public async Task AddPresidentToTeam(int teamId, Guid presidentId, CancellationToken cancellationToken)
        {
            Team team = await this.GetTeamById(teamId);
            team.PresidentId = presidentId;

            await this.Data.SaveChangesAsync(cancellationToken);
        }

        public async Task AddPlayerToTeam(int teamId, Guid playerId, CancellationToken cancellationToken)
        {
            Team team = await this.GetTeamById(teamId);
            team.AddPlayer(playerId);

            await this.Data.SaveChangesAsync(cancellationToken);
        }

        public async Task<Team> GetTeamById(int teamId, CancellationToken cancellationToken = default)
        {
            return await this.Data.Teams.FirstOrDefaultAsync(t => t.Id == teamId, cancellationToken);
        }
    }
}

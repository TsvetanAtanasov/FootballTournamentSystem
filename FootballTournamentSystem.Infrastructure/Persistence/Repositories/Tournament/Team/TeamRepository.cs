namespace FootballTournamentSystem.Infrastructure.Persistence.Repositories.Tournament.Team
{
    using Domain.Models.Tournament.Team;
    using FootballTournamentSystem.Application.Features.Tournament.Team;
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

        public async Task AddCoachToTeam(int teamId, Guid coachId, CancellationToken cancellationToken)
        {
            Team team = await this.GetTeamById(teamId);
            team.AddCoach(coachId);

            await this.Data.SaveChangesAsync(cancellationToken);
        }

        public async Task<Team> GetTeamById(int teamId, CancellationToken cancellationToken = default)
        {
            return await this.Data.Teams.FirstOrDefaultAsync(t => t.Id == teamId, cancellationToken);
        }
    }
}

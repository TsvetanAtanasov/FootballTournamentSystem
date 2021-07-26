namespace FootballTournamentSystem.Infrastructure.Persistence.Repositories.TournamentContext.Match
{
    using Common.Infrastructure.Persistence;
    using Domain.Models.TournamentContext.Match;
    using FootballTournamentSystem.Application.Features.TournamentContext.Match;
    using Microsoft.EntityFrameworkCore;
    using System.Threading;
    using System.Threading.Tasks;

    internal class MatchRepository : DataRepository<FootballTournamentDbContext, Match>, IMatchRepository
    {
        public MatchRepository(FootballTournamentDbContext db)
            : base(db)
        {

        }

        public async Task<Match> GetMatchById(int matchId, CancellationToken cancellationToken = default)
        {
            return await this.Data.Matches.FirstOrDefaultAsync(m => m.Id == matchId, cancellationToken);
        }
    }
}

namespace FootballTournamentSystem.Tournament.Infrastructure.Repositories.Match
{
    using Domain.Models.Tournament.Match;
    using FootballTournamentSystem.Application.Features.Tournament.Match;
    using Microsoft.EntityFrameworkCore;
    using System.Threading;
    using System.Threading.Tasks;

    internal class MatchRepository : FootballTournamentDataRepository<Match>, IMatchRepository
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

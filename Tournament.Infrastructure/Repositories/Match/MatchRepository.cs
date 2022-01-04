namespace FootballTournamentSystem.Tournament.Infrastructure.Repositories.Match
{
    using Microsoft.EntityFrameworkCore;
    using System.Threading;
    using System.Threading.Tasks;
    using FootballTournamentSystem.Tournament.Application.Features.Match;
    using FootballTournamentSystem.Tournament.Domain.Models.Match;
    using Core.Infrastructure.Persistence;
    using FootballTournamentSystem.Tournament.Infrastructure.Persistance;

    internal class MatchRepository : FootballTournamentDataRepository<Match>, IMatchRepository
    {
        public MatchRepository(TournamentDbContext db)
            : base(db)
        {

        }

        public async Task<Match> GetMatchById(int matchId, CancellationToken cancellationToken = default)
        {
            return await this.Data.Matches.FirstOrDefaultAsync(m => m.Id == matchId, cancellationToken);
        }
    }
}

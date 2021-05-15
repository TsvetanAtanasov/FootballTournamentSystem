namespace FootballTournamentSystem.Infrastructure.Persistence.Repositories.PersonContext.Player
{
    using Domain.Models.PersonContext.Player;
    using FootballTournamentSystem.Application.Features.PersonContext.Player;
    using Microsoft.EntityFrameworkCore;
    using System.Threading;
    using System.Threading.Tasks;

    internal class PlayerRepository : DataRepository<Player>, IPlayerRepository
    {
        public PlayerRepository(FootballTournamentDbContext db)
            : base(db)
        {

        }

        public async Task<Player> GetPlayerById(int playerId, CancellationToken cancellationToken = default)
        {
            return await this.Data.Players.FirstOrDefaultAsync(p => p.Id == playerId, cancellationToken);
        }
    }
}

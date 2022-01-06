namespace FootballTournamentSystem.Person.Infrastructure.Repositories.Player
{
    using FootballTournamentSystem.Person.Domain.Models.Player;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using FootballTournamentSystem.Person.Application.Features.Player;
    using FootballTournamentSystem.Person.Infrastructure.Persistance;

    internal class PlayerRepository : FootballTournamentDataRepository<Player>, IPlayerRepository
    {
        public PlayerRepository(PersonDbContext db)
            : base(db)
        {

        }

        public async Task<Player> GetPlayerById(Guid playerId, CancellationToken cancellationToken = default)
        {
            return await this.Data.Players.FirstOrDefaultAsync(p => p.Id == playerId, cancellationToken);
        }
    }
}

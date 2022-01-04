namespace FootballTournamentSystem.Infrastructure.Persistence.Repositories.Person.Player
{
    using Core.Infrastructure.Persistence;
    using Domain.Models.Person.Player;
    using FootballTournamentSystem.Application.Features.Person.Player;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    internal class PlayerRepository : FootballTournamentDataRepository<Player>, IPlayerRepository
    {
        public PlayerRepository(FootballTournamentDbContext db)
            : base(db)
        {

        }

        public async Task<Player> GetPlayerById(Guid playerId, CancellationToken cancellationToken = default)
        {
            return await this.Data.Players.FirstOrDefaultAsync(p => p.Id == playerId, cancellationToken);
        }
    }
}

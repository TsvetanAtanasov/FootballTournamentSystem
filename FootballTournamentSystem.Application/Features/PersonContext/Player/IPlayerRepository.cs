namespace FootballTournamentSystem.Application.Features.PersonContext.Player
{
    using System.Threading;
    using System.Threading.Tasks;
    using Application.Contracts;
    using Domain.Models.PersonContext.Player;

    public interface IPlayerRepository : IRepository<Player>
    {
        Task<Player> GetPlayerById(int playerId, CancellationToken cancellationToken = default);
    }
}

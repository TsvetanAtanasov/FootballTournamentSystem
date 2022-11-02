namespace FootballTournamentSystem.Person.Application.Features.Player
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using Core.Application.Contracts;
    using FootballTournamentSystem.Person.Domain.Models.Player;

    public interface IPlayerRepository : IRepository<Player>
    {
        Task<Player> GetPlayerById(int playerId, CancellationToken cancellationToken = default);
    }
}

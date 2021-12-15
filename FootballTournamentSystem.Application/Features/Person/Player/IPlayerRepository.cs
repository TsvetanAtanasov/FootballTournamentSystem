namespace FootballTournamentSystem.Application.Features.Person.Player
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using Core.Application.Contracts;
    using Domain.Models.Person.Player;

    public interface IPlayerRepository : IRepository<Player>
    {
        Task<Player> GetPlayerById(Guid playerId, CancellationToken cancellationToken = default);
    }
}

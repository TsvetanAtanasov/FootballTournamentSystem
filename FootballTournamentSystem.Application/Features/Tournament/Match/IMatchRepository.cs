namespace FootballTournamentSystem.Application.Features.Tournament.Match
{
    using Application.Contracts;
    using Domain.Models.Tournament.Match;
    using System.Threading;
    using System.Threading.Tasks;

    public interface IMatchRepository : IRepository<Match>
    {
        Task<Match> GetMatchById(int matchId, CancellationToken cancellationToken = default);
    }
}
namespace FootballTournamentSystem.Tournament.Application.Features.Match
{
    using System.Threading;
    using System.Threading.Tasks;
    using Core.Application.Contracts;
    using FootballTournamentSystem.Tournament.Domain.Models.Match;

    public interface IMatchRepository : IRepository<Match>
    {
        Task<Match> GetMatchById(int matchId, CancellationToken cancellationToken = default);
    }
}